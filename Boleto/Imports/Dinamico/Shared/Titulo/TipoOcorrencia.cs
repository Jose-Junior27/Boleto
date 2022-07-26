﻿namespace ACBrLib.Boleto
{
    public enum TipoOcorrencia
    {
        toRemessaRegistrar,
        toRemessaBaixar,
        toRemessaDebitarEmConta,
        toRemessaConcederAbatimento,
        toRemessaCancelarAbatimento,
        toRemessaConcederDesconto,
        toRemessaCancelarDesconto,
        toRemessaAlterarVencimento,
        toRemessaAlterarVencimentoSustarProtesto,
        toRemessaProtestar,
        toRemessaSustarProtesto,
        toRemessaCancelarInstrucaoProtestoBaixa,
        toRemessaCancelarInstrucaoProtesto,
        toRemessaDispensarJuros,
        toRemessaAlterarNomeEnderecoSacado,
        toRemessaAlterarNumeroControle,
        toRemessaOutrasOcorrencias,
        toRemessaAlterarControleParticipante,
        toRemessaAlterarSeuNumero,
        toRemessaTransfCessaoCreditoIDProd10,
        toRemessaTransferenciaCarteira,
        toRemessaDevTransferenciaCarteira,
        toRemessaDesagendarDebitoAutomatico,
        toRemessaAcertarRateioCredito,
        toRemessaCancelarRateioCredito,
        toRemessaAlterarUsoEmpresa,
        toRemessaNaoProtestar,
        toRemessaProtestoFinsFalimentares,
        toRemessaBaixaporPagtoDiretoCedente,
        toRemessaCancelarInstrucao,
        toRemessaAlterarVencSustarProtesto,
        toRemessaCedenteDiscordaSacado,
        toRemessaCedenteSolicitaDispensaJuros,
        toRemessaOutrasAlteracoes,
        toRemessaAlterarModalidade,
        toRemessaAlterarExclusivoCliente,
        toRemessaNaoCobrarJurosMora,
        toRemessaCobrarJurosMora,
        toRemessaAlterarValorTitulo,
        toRemessaExcluirSacadorAvalista,
        toRemessaAlterarNumeroDiasProtesto,
        toRemessaAlterarPrazoProtesto,
        toRemessaAlterarPrazoDevolucao,
        toRemessaAlterarOutrosDados,
        toRemessaAlterarDadosEmissaoBloqueto,
        toRemessaAlterarProtestoDevolucao,
        toRemessaAlterarDevolucaoProtesto,
        toRemessaNegativacaoSerasa,
        toRemessaExcluirNegativacaoSerasa,
        toRemessaAlterarJurosMora,
        toRemessaAlterarMulta,
        toRemessaDispensarMulta,
        toRemessaAlterarDesconto,
        toRemessaNaoConcederDesconto,
        toRemessaAlterarValorAbatimento,
        toRemessaAlterarPrazoLimiteRecebimento,
        toRemessaDispensarPrazoLimiteRecebimento,
        toRemessaAlterarNumeroTituloBeneficiario,
        toRemessaAlterarDadosPagador,
        toRemessaAlterarDadosSacadorAvalista,
        toRemessaRecusaAlegacaoPagador,
        toRemessaAlterarDadosRateioCredito,
        toRemessaPedidoCancelamentoDadosRateioCredito,
        toRemessaPedidoDesagendamentoDebietoAutom,
        toRemessaAlterarEspecieTitulo,
        toRemessaAlterarContratoCobran,
        toRemessaNegativacaoSemProtesto,
        toRemessaBaixaTituloNegativadoSemProtesto,
        toRemessaAlterarValorMinimo,
        toRemessaAlterarValorMaximo,
        toRemessaExcluirNegativacaoSerasaBaixar,
        toRemessaPedidoNegativacao,
        toRemessaExcluirNegativacaoBaixar,
        toRemessaExcluirNegativacaoManterEmCarteira,
        toRemessaSustarProtestoBaixarTitulo,
        toRemessaSustarProtestoManterCarteira,
        toRemessaRecusaAlegacaoSacado,
        toRemessaProtestoAutomatico,
        toRemessaAlterarStatusDesconto,

        //Ocorrências para arquivo retorno
        toRetornoAbatimentoCancelado,

        toRetornoAbatimentoConcedido,
        toRetornoAcertoControleParticipante,
        toRetornoAcertoDadosRateioCredito,
        toRetornoAcertoDepositaria,
        toRetornoAguardandoAutorizacaoProtestoEdital,
        toRetornoAlegacaoDoSacado,
        toRetornoAlteracaoDadosBaixa,
        toRetornoAlteracaoDadosNovaEntrada,
        toRetornoAlteracaoDadosRejeitados,
        toRetornoAlteracaoDataEmissao,
        toRetornoAlteracaoEspecie,
        toRetornoAlteracaoInstrucao,
        toRetornoAlteracaoOpcaoDevolucaoParaProtestoConfirmada,
        toRetornoAlteracaoOpcaoProtestoParaDevolucaoConfirmada,
        toRetornoAlteracaoOutrosDadosRejeitada,
        toRetornoAlteracaoReemissaoBloquetoConfirmada,
        toRetornoAlteracaoSeuNumero,
        toRetornoAlteracaoUsoCedente,
        toRetornoAlterarDataDesconto,
        toRetornoAlterarPrazoLimiteRecebimento,
        toRetornoAlterarSacadorAvalista,
        toRetornoBaixaAutomatica,
        toRetornoBaixaCreditoCCAtravesSispag,
        toRetornoBaixaCreditoCCAtravesSispagSemTituloCorresp,
        toRetornoBaixado,
        toRetornoBaixadoFrancoPagamento,
        toRetornoBaixadoInstAgencia,
        toRetornoBaixadoPorDevolucao,
        toRetornoBaixadoViaArquivo,
        toRetornoBaixaLiquidadoEdital,
        toRetornoBaixaManualConfirmada,
        toRetornoBaixaOuLiquidacaoEstornada,
        toRetornoBaixaPorProtesto,
        toRetornoBaixaPorTerSidoLiquidado,
        toRetornoBaixaRejeitada,
        toRetornoBaixaSimples,
        toRetornoBaixaSolicitada,
        toRetornoBaixaTituloNegativadoSemProtesto,
        toRetornoBaixaTransferenciaParaDesconto,
        toRetornoCancelamentoDadosRateio,
        toRetornoChequeCompensado,
        toRetornoChequeDevolvido,
        toRetornoChequePendenteCompensacao,
        toRetornoCobrancaContratual,
        toRetornoCobrancaCreditar,
        toRetornoComandoRecusado,
        toRetornoConfCancelamentoNegativacaoExpressaTarifa,
        toRetornoConfEntradaNegativacaoExpressaTarifa,
        toRetornoConfExclusaoEntradaNegativacaoExpressaPorLiquidacaoTarifa,
        toRetornoConfInstrucaoTransferenciaCarteiraModalidadeCobranca,
        toRetornoConfirmacaoAlteracaoBancoSacado,
        toRetornoConfirmacaoAlteracaoJurosMora,
        toRetornoConfirmacaoEmailSMS,
        toRetornoConfirmacaoEntradaCobrancaSimples,
        toRetornoConfirmacaoExclusaoBancoSacado,
        toRetornoConfirmacaoInclusaoBancoSacado,
        toRetornoConfirmacaoPedidoExclNegativacao,
        toRetornoConfirmacaoRecebPedidoNegativacao,
        toRetornoConfirmaRecebimentoInstrucaoNaoNegativar,
        toRetornoConfRecebimentoInstCancelamentoNegativacaoExpressa,
        toRetornoConfRecebimentoInstEntradaNegativacaoExpressa,
        toRetornoConfRecebimentoInstExclusaoEntradaNegativacaoExpressa,
        toRetornoCustasCartorio,
        toRetornoCustasCartorioDistribuidor,
        toRetornoCustasEdital,
        toRetornoCustasIrregularidade,
        toRetornoCustasProtesto,
        toRetornoCustasSustacao,
        toRetornoCustasSustacaoJudicial,
        toRetornoDadosAlterados,
        toRetornoDebitoCustasAntecipadas,
        toRetornoDebitoDiretoAutorizado,
        toRetornoDebitoDiretoNaoAutorizado,
        toRetornoDebitoEmConta,
        toRetornoDebitoMensalTarifaAvisoMovimentacaoTitulos,
        toRetornoDebitoMensalTarifasExtradoPosicao,
        toRetornoDebitoMensalTarifasManutencaoTitulosVencidos,
        toRetornoDebitoMensalTarifasOutrasInstrucoes,
        toRetornoDebitoMensalTarifasOutrasOcorrencias,
        toRetornoDebitoMensalTarifasProtestos,
        toRetornoDebitoMensalTarifasSustacaoProtestos,
        toRetornoDebitoTarifas,
        toRetornoDesagendamentoDebitoAutomatico,
        toRetornoDescontoCancelado,
        toRetornoDescontoConcedido,
        toRetornoDescontoRetificado,
        toRetornoDespesaCartorio,
        toRetornoDespesasProtesto,
        toRetornoDespesasSustacaoProtesto,
        toRetornoDevolvidoPeloCartorio,
        toRetornoDispensarIndexador,
        toRetornoDispensarPrazoLimiteRecebimento,
        toRetornoEmailSMSRejeitado,
        toRetornoEmissaoBloquetoBancoSacado,
        toRetornoEncaminhadoACartorio,
        toRetornoEnderecoSacadoAlterado,
        toRetornoEntradaBorderoManual,
        toRetornoEntradaConfirmadaRateioCredito,
        toRetornoEntradaEmCartorio,
        toRetornoEntradaRegistradaAguardandoAvaliacao,
        toRetornoEntradaRejeitaCEPIrregular,
        toRetornoEntradaRejeitadaCarne,
        toRetornoEntradaTituloBancoSacadoRejeitada,
        toRetornoEqualizacaoVendor,
        toRetornoEstornoBaixaLiquidacao,
        toRetornoEstornoPagamento,
        toRetornoEstornoProtesto,
        toRetornoInstrucaoCancelada,
        toRetornoInstrucaoNegativacaoExpressaRejeitada,
        toRetornoInstrucaoProtestoRejeitadaSustadaOuPendente,
        toRetornoInstrucaoRejeitada,
        toRetornoIOFInvalido,
        toRetornoJurosDispensados,
        toRetornoLiquidado,
        toRetornoLiquidadoAposBaixaOuNaoRegistro,
        toRetornoLiquidadoEmCartorio,
        toRetornoLiquidadoParcialmente,
        toRetornoLiquidadoPorConta,
        toRetornoLiquidadoSaldoRestante,
        toRetornoLiquidadoSemRegistro,
        toRetornoManutencaoBancoSacadoRejeitada,
        toRetornoManutencaoSacadoRejeitada,
        toRetornoManutencaoTituloVencido,
        toRetornoNegativacaoExpressaInformacional,
        toRetornoNomeSacadoAlterado,
        toRetornoOcorrenciasDoSacado,
        toRetornoOutrasOcorrencias,
        toRetornoOutrasTarifasAlteracao,
        toRetornoPagadorDDA,
        toRetornoPrazoDevolucaoAlterado,
        toRetornoPrazoProtestoAlterado,
        toRetornoProtestado,
        toRetornoProtestoImediatoFalencia,
        toRetornoProtestoOuSustacaoEstornado,
        toRetornoProtestoSustado,
        toRetornoRecebimentoInstrucaoAlterarDados,
        toRetornoRecebimentoInstrucaoAlterarEnderecoSacado,
        toRetornoRecebimentoInstrucaoAlterarJuros,
        toRetornoRecebimentoInstrucaoAlterarNomeSacado,
        toRetornoRecebimentoInstrucaoAlterarTipoCobranca,
        toRetornoRecebimentoInstrucaoAlterarValorTitulo,
        toRetornoRecebimentoInstrucaoAlterarVencimento,
        toRetornoRecebimentoInstrucaoBaixar,
        toRetornoRecebimentoInstrucaoCancelarAbatimento,
        toRetornoRecebimentoInstrucaoCancelarDesconto,
        toRetornoRecebimentoInstrucaoConcederAbatimento,
        toRetornoRecebimentoInstrucaoConcederDesconto,
        toRetornoRecebimentoInstrucaoDispensarJuros,
        toRetornoRecebimentoInstrucaoNaoProtestar,
        toRetornoRecebimentoInstrucaoProtestar,
        toRetornoRecebimentoInstrucaoSustarProtesto,
        toRetornoReembolsoDevolucaoDescontoVendor,
        toRetornoReembolsoNaoEfetuado,
        toRetornoReembolsoTransferenciaDescontoVendor,
        toRetornoRegistroConfirmado,
        toRetornoRegistroRecusado,
        toRetornoRelacaoDeTitulos,
        toRetornoRemessaRejeitada,
        toRetornoReservado,
        toRetornoRetiradoDeCartorio,
        toRetornoSegundaViaInstrumentoProtesto,
        toRetornoSegundaViaInstrumentoProtestoCartorio,
        toRetornoSolicitacaoImpressaoTituloConfirmada,
        toRetornoSustacaoEnvioCartorio,
        toRetornoSustadoJudicial,
        toRetornoTarifaAvisoCobranca,
        toRetornoTarifaDeManutencaoDeTitulosVencidos,
        toRetornoTarifaDeRelacaoDasLiquidacoes,
        toRetornoTarifaEmailCobrancaAtivaEletronica,
        toRetornoTarifaEmissaoAvisoMovimentacaoTitulos,
        toRetornoTarifaEmissaoBoletoEnvioDuplicata,
        toRetornoTarifaExtratoPosicao,
        toRetornoTarifaInstrucao,
        toRetornoTarifaMensalBaixasBancosCorrespCarteira,
        toRetornoTarifaMensalBaixasCarteira,
        toRetornoTarifaMensalCancelamentoNegativacaoExpressa,
        toRetornoTarifaMensalEmailCobrancaAtivaEletronica,
        toRetornoTarifaMensalEmissaoBoletoEnvioDuplicata,
        toRetornoTarifaMensalExclusaoEntradaNegativacaoExpressa,
        toRetornoTarifaMensalExclusaoNegativacaoExpressaPorLiquidacao,
        toRetornoTarifaMensalLiquidacoesBancosCorrespCarteira,
        toRetornoTarifaMensalLiquidacoesCarteira,
        toRetornoTarifaMensalPorBoletoAte03EnvioCobrancaAtivaEletronica,
        toRetornoTarifaMensalRefEntradasBancosCorrespCarteira,
        toRetornoTarifaMensalSMSCobrancaAtivaEletronica,
        toRetornoTarifaOcorrencias,
        toRetornoTarifaPorBoletoAte03EnvioCobrancaAtivaEletronica,
        toRetornoTarifaSMSCobrancaAtivaEletronica,
        toRetornoTipoCobrancaAlterado,
        toRetornoTituloDDANaoReconhecidoPagador,
        toRetornoTituloDDAReconhecidoPagador,
        toRetornoTituloDDARecusadoCIP,
        toRetornoTituloEmSer,
        toRetornoTituloJaBaixado,
        toRetornoTituloNaoExiste,
        toRetornoTituloPagamentoCancelado,
        toRetornoTituloPagoEmCheque,
        toRetornoTituloSustadoJudicialmente,
        toRetornoTransferenciaCarteira,
        toRetornoTransferenciaCarteiraBaixa,
        toRetornoTransferenciaCarteiraEntrada,
        toRetornoTransferenciaCedente,
        toRetornoTransitoPagoCartorio,
        toRetornoVencimentoAlterado,
        toRetornoRejeicaoSacado,
        toRetornoAceiteSacado,
        toRetornoLiquidadoOnLine,
        toRetornoEstornoLiquidacaoOnLine,
        toRetornoConfirmacaoAlteracaoValorNominal,
        toRetornoConfirmacaoAlteracaoValorpercentualMinimoMaximo,
        toTipoOcorrenciaNenhum,
        toRetornoConfRecPedidoNegativacao,
        toRetornoConfRecPedidoExclusaoNegativacao,
        toRetornoConfEntradaNegativacao,
        toRetornoEntradaNegativacaoRejeitada,
        toRetornoConfExclusaoNegativacao,
        toRetornoExclusaoNegativacaoRejeitada,
        toRetornoExcusaoNegativacaoOutrosMotivos,
        toRetornoOcorrenciaInfOutrosMotivos,
        toRetornoInclusaoNegativacao,
        toRetornoExclusaoNegativacao,
        toRetornoEmTransito,
        toRetornoLiquidadoEmCartorioEmCondicionalComChequeDoDevedor,
        toRetornoProtestoSustadoDefinitivo,
        toRetornoLiquidadoTituloDescontado,
        toRetornoProtestadoEmCartorio,
        toRetornoSustacaoSolicitada,
        toRetornoTituloDescontado,
        toRetornoTituloDescontavel,
        toRetornoIntensaoPagamento
    }
}