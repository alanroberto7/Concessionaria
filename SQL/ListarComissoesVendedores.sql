/* ListarComissoesVendedores.sql

SCRIPT PARA DA PROCEDURE ListarComissoesVendedores.
Deve ser executado após a criação das tabelas.

*/

USE DBCONCESSIONARIA
GO

CREATE OR ALTER PROCEDURE ListarComissoesVendedores 
AS
    SELECT 
		NmeVendedor,
		QtdVendas = COUNT(IdeVenda),
		QtdVales = SUM(CAST(StaValeCombustivel AS INT)),
		VlrTotalVendas = SUM(VlrPrecoVenda),
		--VlrTotalComissaoDefualt = SUM(VlrPrecoComissaoDefault),
		--VlrTotalValeCombustivel = SUM(VlrValeCombustivel),
		VlrTotalComissao = SUM(VlrPrecoComissaoDefault - VlrValeCombustivel)
	FROM 
	(
		SELECT 
			VND001.NmeVendedor,
			VND002.IdeVenda,
			VND002.StaValeCombustivel,
			VND002.VlrPrecoVenda,
			VlrPrecoComissaoDefault = (VND002.VlrPrecoVenda * 1 / 100),
			VlrValeCombustivel = 
			(
				CASE VND002.StaValeCombustivel
					WHEN  1 THEN 
					(
						CASE VEI004.IdeCombustivel
							WHEN  1 THEN 200 --Gasolina
							WHEN  2 THEN 180 --Álcool
							WHEN  3 THEN 150 --Diesel
							ELSE 0 
						END
					)
					ELSE 0 
				END
			)
		FROM VND002_VENDA VND002
		INNER JOIN VND001_VENDEDOR VND001 ON VND001.IdeVendedor  = 	VND002.IdeVendedor
		INNER JOIN VEI004_MODELO_VERSAO VEI004 ON VEI004.IdeModeloVersao = VND002.IdeModeloVersao
	) a
	GROUP BY NmeVendedor
GO