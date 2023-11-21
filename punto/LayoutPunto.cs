using System.Globalization;


namespace punto
{
	public class LayoutPunto
	{
        String? tipoFormatacao = "/";

        String? A0_codigoigoRegistro; 
        String? A0_versaoLayout; 
        String? A0_administradora;
        String? A0_tipoProcessamento;
        String? A0_dataGeracaoArquivo;
        String? A0_horaGeracaoArquivo;
        String? A0_identificadorMoviment;
        String? A0_identificadorRemetente;
        String? A0_identificadorDestinatorio;
		String? A0_nsqeRegistro;

        String? L0_codigo_registroistro;
        String? L0_data_movimento; 
        String? L0_identificador_moeda; 
        String? L0_nseq;

        String? CV_codigo_registro;
        String? CV_identificador_loja;
        String? CV_NSU;
        String? CV_data_transacao;
        String? CV_hora_transacao;
        String? CV_Tipo_lanc;
        String? CV_data_pg;
        String? CV_Mod_transacao;
        String? CV_Meio_cap;
        String? CV_bruto;
        String? CV_desc;
        String? CV_liqui;
        String? CV_n_cartao;
        String? CV_numero_parcela;
        String? CV_numero_total_parce;
        String? CV_nsu_parcela;
        String? CV_bruto_parcela;
        String? CV_desc_parcela;
        String? CV_liquido_parcela;
        String? CV_banco;
        String? CV_agencia;
        String? CV_conta_corrente;
        String? CV_aut;
        String? CV_bandeira;
        String? CV_produto;
        String? CV_valor_taxa_inter_tarifa;
        String? CV_taxa_adm;
        String? CV_valor_taxa_in_tarif_parcela;
        String? CV_valor_taxa_adm_parcela;
        String? CV_valor_redutor;
        String? CV_valor_taxa_antec;
        String? CV_valor_liq_ant;
        String? CV_origen_transacao;
        String? CV_codigo_pedido;
        String? CV_sigla_pais;
        String? CV_num_term;
        String? CV_reservado;
        String? CV_transacao_identificador;
        String? CV_payment_identificador;
        String? CV_identificador_pix;
        String? CV_sweq;

        String? AJ_codigo_registro;
        String? AJ_identificador_loja;
        String? AJ_NSU_transacao_orig;
        String? AJ_data_transacao;
        String? AJ_numero_parcela;
        String? AJ_nus_transacao;
        String? AJ_data_aj;
        String? AJ_hora_transacao;
        String? AJ_tipo_lancamento;
        String? AJ_data_lancamento;
        String? AJ_meio_cap_ajust;
        String? AJ_tipo_ajuste;
        String? AJ_codigo_ajust;
        String? AJ_desc_motivo_ajust;
        String? AJ_valor_bruto;
        String? AJ_valor_desc_comicao;
        String? AJ_valor_liquido;
        String? AJ_banco;
        String? AJ_agencia;
        String? AJ_conta_corrente;
        String? AJ_numero_card_transacao_original;
        String? AJ_codigo_bandeira;
        String? AJ_codigo_produto;
        String? AJ_valor_taxa_anten;
        String? AJ_valor_liqui_antec;
        String? AJ_codigo_pedido;
        String? AJ_reservado;
        String? AJ_nseq;

        String? CC_codigo_registro;
        String? CC_identificador_loja;
        String? CC_NSU_transacao_orig;
        String? CC_data_transacao_original;
        String? CC_data_transacao_cancelamento;
        String? CC_horaio_transacao_cancelmento;
        String? CC_meio_cap;
        String? CC_bruto_transacao_original;
        String? CC_vaL0_des_comi_cancelamento;
        String? CC_liqui_transacao_original;
        String? CC_numero_parcela;
        String? CC_numero_parc_transacao_original;
        String? CC_nsu_parcela;
        String? CC_valor_bruto_parcela_Cancelemento;
        String? CC_vaL0_liqui_parcela;
        String? CC_codigo_aut_originial;
        String? CC_valot_tax_inter_tarif;
        String? CC_valor_taxa_adm;
        String? CC_valor_taxa_int_tarif_parce;
        String? CC_valor_taxa_adm_parcela;
        String? CC_valor_red_mult_fronteira;
        String? CC_vaL0_taxa_ant;
        String? CC_valor_liquuido_antec;
        String? CC_identificador_envelop;
        String? CC_reservado;
        String? CC_transacao_identificador;
        String? CC_payment_identificador;
        String? CC_identificador_pix;
        String? CC_nseq;

        String? L9_codigo_registro;
        String? L9_total_transacao;
        String? L9_total_valores_cred;
        String? L9_nseq;

        String? A9_codigo_registro;
        String? A9_total_transacao;
        String? A9_nseq_registroistro;

        TableAux tabelasAuxiliares = new TableAux(); 

        public String A0(String linha)
		{
            A0_codigoigoRegistro = formatter(linha: linha, pos: 1, tam: 2, tipo: "t");
            A0_versaoLayout = formatter(linha: linha, pos: 3, tam: 6, tipo: "t");
            A0_dataGeracaoArquivo = formatter(linha: linha, pos: 9, tam: 8, tipo: "d");
            A0_horaGeracaoArquivo = formatter(linha: linha, pos: 17, tam: 6, tipo: "t");
            A0_identificadorMoviment = formatter(linha: linha, pos: 23, tam: 6, tipo: "t");
            A0_administradora = formatter(linha: linha, pos: 29, tam: 30, tipo: "t");
            A0_identificadorRemetente = formatter(linha: linha, pos: 59, tam: 4, tipo: "t");
            A0_identificadorDestinatorio = formatter(linha: linha, pos: 63, tam: 9, tipo: "t");
            A0_tipoProcessamento = formatter(linha: linha, pos: 72, tam: 1, tipo: "t");
            A0_nsqeRegistro = formatter(linha: linha, pos: 73, tam: 6, tipo: "t");

            return String.Concat(
                A0_codigoigoRegistro, tipoFormatacao,
                A0_versaoLayout, tipoFormatacao,
                A0_dataGeracaoArquivo, tipoFormatacao,
                A0_identificadorMoviment, tipoFormatacao,
                A0_administradora, tipoFormatacao,
                A0_identificadorRemetente, tipoFormatacao,
                A0_identificadorDestinatorio, tipoFormatacao,
                A0_tipoProcessamento, tipoFormatacao,
                A0_nsqeRegistro, tipoFormatacao
                );
         
		}
        public String L0(String linha)
        {
            L0_codigo_registroistro = formatter(linha:linha,pos:1,tam:2, tipo: "t");
            L0_data_movimento = formatter(linha: linha, pos: 3, tam: 8, tipo: "d");
            L0_identificador_moeda = formatter(linha: linha, pos: 11, tam: 2, tipo: "t");
            L0_nseq = formatter(linha: linha, pos: 13, tam: 6, tipo: "t");

            return String.Concat(
                L0_codigo_registroistro, tipoFormatacao,
                L0_data_movimento, tipoFormatacao,
                L0_identificador_moeda, tipoFormatacao,
                L0_nseq, tipoFormatacao
                );
        }
        public String CV(String linha)
        {
            CV_codigo_registro = formatter(linha: linha, pos: 1, tam: 2, tipo: "t");
            CV_identificador_loja = formatter(linha: linha, pos: 3, tam: 15, tipo: "t");
            CV_NSU = formatter(linha: linha, pos: 18, tam: 12, tipo: "t");
            CV_data_transacao = formatter(linha: linha, pos: 30, tam: 8, tipo: "d");
            CV_hora_transacao = formatter(linha: linha, pos: 38, tam: 6, tipo: "h");
            CV_Tipo_lanc = tabelasAuxiliares.lancamento(valor: formatter(linha: linha, pos: 44, tam: 1, tipo: "t"));
            CV_data_pg = formatter(linha: linha, pos: 45, tam: 8, tipo: "d");
            CV_Mod_transacao = formatter(linha: linha, pos: 53, tam: 1, tipo: "t");
            CV_Meio_cap = tabelasAuxiliares.meio_captura(valor: formatter(linha: linha, pos: 54, tam: 1, tipo: "t"));
            CV_bruto = formatter(linha: linha, pos: 55, tam: 11, tipo: "m");
            CV_desc = formatter(linha: linha, pos: 66, tam: 11, tipo: "m");
            CV_liqui = formatter(linha: linha, pos: 77, tam: 11, tipo: "m");
            CV_n_cartao = formatter(linha: linha, pos: 88, tam: 19, tipo: "t");
            CV_numero_parcela = formatter(linha: linha, pos: 107, tam: 2, tipo: "t");
            CV_numero_total_parce = formatter(linha: linha, pos: 109, tam: 2, tipo: "t");
            CV_nsu_parcela = formatter(linha: linha, pos: 111, tam: 12, tipo: "t");
            CV_bruto_parcela = formatter(linha: linha, pos: 123, tam: 11, tipo: "m");
            CV_desc_parcela = formatter(linha: linha, pos: 134, tam: 11, tipo: "m");
            CV_liquido_parcela = formatter(linha: linha, pos: 145, tam: 11, tipo: "t");
            CV_banco = formatter(linha: linha, pos: 156, tam: 3, tipo: "t");
            CV_agencia = formatter(linha: linha, pos: 159, tam: 6, tipo: "t");
            CV_conta_corrente = formatter(linha: linha, pos: 165, tam: 11, tipo: "t");
            CV_aut = formatter(linha: linha, pos: 176, tam: 12, tipo: "t");
            CV_bandeira = tabelasAuxiliares.Bandeiras(valor: formatter(linha: linha, pos: 188, tam: 3, tipo: "t"));
            CV_produto = tabelasAuxiliares.codigo_produto(valor:formatter(linha: linha, pos: 191, tam: 3, tipo: "t"));
            CV_valor_taxa_inter_tarifa = formatter(linha: linha, pos: 194, tam: 11, tipo: "t");
            CV_taxa_adm = formatter(linha: linha, pos: 205, tam: 11, tipo: "m");
            CV_valor_taxa_in_tarif_parcela = formatter(linha: linha, pos: 216, tam: 11, tipo: "m");
            CV_valor_taxa_adm_parcela = formatter(linha: linha, pos: 227, tam: 11, tipo: "m");
            CV_valor_redutor = formatter(linha: linha, pos: 238, tam: 11, tipo: "m");
            CV_valor_taxa_antec = formatter(linha: linha, pos: 249, tam: 11, tipo: "m");
            CV_valor_liq_ant = formatter(linha: linha, pos: 260, tam: 11, tipo: "m");
            CV_origen_transacao = tabelasAuxiliares.origem_transacao(valor: formatter(linha: linha, pos: 271, tam: 2, tipo: "t"));
            CV_codigo_pedido = formatter(linha: linha, pos: 273, tam: 19, tipo: "t");
            CV_sigla_pais = formatter(linha: linha, pos: 292, tam: 3, tipo: "t");
            CV_num_term = formatter(linha: linha, pos: 295, tam: 40, tipo: "t");
            CV_reservado = formatter(linha: linha, pos: 335, tam: 80, tipo: "t");
            CV_transacao_identificador = formatter(linha: linha, pos: 415, tam: 69, tipo: "t");
            CV_payment_identificador = formatter(linha: linha, pos: 484, tam: 36, tipo: "t");
            CV_identificador_pix = formatter(linha: linha, pos: 520, tam: 36, tipo: "t");
            CV_sweq = formatter(linha: linha, pos: 556, tam: 6, tipo: "t");

            return String.Concat(
            CV_codigo_registro, tipoFormatacao,
            CV_identificador_loja, tipoFormatacao,
            CV_NSU, tipoFormatacao,
            CV_data_transacao, tipoFormatacao,
            CV_hora_transacao, tipoFormatacao,
            CV_Tipo_lanc, tipoFormatacao,
            CV_data_pg, tipoFormatacao,
            CV_Mod_transacao, tipoFormatacao,
            CV_Meio_cap, tipoFormatacao,
            CV_bruto, tipoFormatacao,
            CV_desc, tipoFormatacao,
            CV_liqui, tipoFormatacao,
            CV_n_cartao, tipoFormatacao,
            CV_numero_parcela, tipoFormatacao,
            CV_numero_total_parce, tipoFormatacao,
            CV_nsu_parcela, tipoFormatacao,
            CV_bruto_parcela, tipoFormatacao,
            CV_desc_parcela, tipoFormatacao,
            CV_liquido_parcela, tipoFormatacao,
            CV_banco, tipoFormatacao,
            CV_agencia, tipoFormatacao,
            CV_conta_corrente, tipoFormatacao,
            CV_aut, tipoFormatacao,
            CV_bandeira, tipoFormatacao,
            CV_produto, tipoFormatacao,
            CV_valor_taxa_inter_tarifa, tipoFormatacao,
            CV_taxa_adm, tipoFormatacao,
            CV_valor_taxa_in_tarif_parcela, tipoFormatacao,
            CV_valor_taxa_adm_parcela, tipoFormatacao,
            CV_valor_redutor, tipoFormatacao,
            CV_valor_taxa_antec, tipoFormatacao,
            CV_valor_liq_ant, tipoFormatacao,
            CV_origen_transacao, tipoFormatacao,
            CV_codigo_pedido, tipoFormatacao,
            CV_sigla_pais, tipoFormatacao,
            CV_num_term, tipoFormatacao,
            CV_reservado, tipoFormatacao,
            CV_transacao_identificador, tipoFormatacao,
            CV_payment_identificador, tipoFormatacao,
            CV_identificador_pix, tipoFormatacao,
            CV_sweq, tipoFormatacao
            );

        }
        public String AJ(String linha)
        {
            AJ_codigo_registro = formatter(linha: linha, pos: 1, tam: 2, tipo: "t");
            AJ_identificador_loja = formatter(linha: linha, pos: 3, tam: 15, tipo: "t");
            AJ_NSU_transacao_orig = formatter(linha: linha, pos: 18, tam: 12, tipo: "t");
            AJ_data_transacao = formatter(linha: linha, pos: 30, tam: 8, tipo: "d");
            AJ_numero_parcela = formatter(linha: linha, pos: 38, tam: 2, tipo: "t");
            AJ_nus_transacao = formatter(linha: linha, pos: 40, tam: 12, tipo: "t");
            AJ_data_aj = formatter(linha: linha, pos: 52, tam: 8, tipo: "d");
            AJ_hora_transacao = formatter(linha: linha, pos: 60, tam: 6, tipo: "h");
            AJ_tipo_lancamento = tabelasAuxiliares.lancamento(valor: formatter(linha: linha, pos: 66, tam: 1, tipo: "t"));
            AJ_data_lancamento = formatter(linha: linha, pos: 67, tam: 8, tipo: "d");
            AJ_meio_cap_ajust = tabelasAuxiliares.meio_captura(valor: formatter(linha: linha, pos: 75, tam: 1, tipo: "t"));
            AJ_tipo_ajuste = tabelasAuxiliares.tipoAjuste(valor: formatter(linha: linha, pos: 76, tam: 1, tipo: "t"));
            AJ_codigo_ajust = formatter(linha: linha, pos: 77, tam: 3, tipo: "t");
            AJ_desc_motivo_ajust = formatter(linha: linha, pos: 80, tam: 30, tipo: "m");
            AJ_valor_bruto = formatter(linha: linha, pos: 110, tam: 11, tipo: "m");
            AJ_valor_desc_comicao = formatter(linha: linha, pos: 111, tam: 12, tipo: "m");
            AJ_valor_liquido = formatter(linha: linha, pos: 121, tam: 11, tipo: "m");
            AJ_banco = formatter(linha: linha, pos: 132, tam: 11, tipo: "t");
            AJ_agencia = formatter(linha: linha, pos: 143, tam: 6, tipo: "t");
            AJ_conta_corrente = formatter(linha: linha, pos: 152, tam: 11, tipo: "t");
            AJ_numero_card_transacao_original = formatter(linha: linha, pos: 163, tam: 19, tipo: "t");
            AJ_codigo_bandeira = tabelasAuxiliares.Bandeiras(valor: formatter(linha: linha, pos: 182, tam: 3, tipo: "t"));
            AJ_codigo_produto = tabelasAuxiliares.codigo_produto(formatter(linha: linha, pos: 185, tam: 3, tipo: "t"));
            AJ_valor_taxa_anten = formatter(linha: linha, pos: 188, tam: 11, tipo: "m");
            AJ_valor_liqui_antec = formatter(linha: linha, pos: 199, tam: 11, tipo: "m");
            AJ_codigo_pedido = formatter(linha: linha, pos: 210, tam: 19, tipo: "t");
            AJ_reservado = formatter(linha: linha, pos: 229, tam: 80, tipo: "t");
            AJ_nseq = formatter(linha: linha, pos: 309, tam: 6, tipo: "t");
          
            return String.Concat(
            AJ_codigo_registro, tipoFormatacao,
            AJ_identificador_loja, tipoFormatacao,
            AJ_NSU_transacao_orig, tipoFormatacao,
            AJ_data_transacao, tipoFormatacao,
            AJ_numero_parcela, tipoFormatacao,
            AJ_nus_transacao, tipoFormatacao,
            AJ_data_aj, tipoFormatacao,
            AJ_hora_transacao, tipoFormatacao,
            AJ_tipo_lancamento, tipoFormatacao,
            AJ_data_lancamento, tipoFormatacao,
            AJ_meio_cap_ajust, tipoFormatacao,
            AJ_tipo_ajuste, tipoFormatacao,
            AJ_codigo_ajust, tipoFormatacao,
            AJ_desc_motivo_ajust, tipoFormatacao,
            AJ_valor_bruto, tipoFormatacao,
            AJ_valor_desc_comicao, tipoFormatacao,
            AJ_valor_liquido, tipoFormatacao,
            AJ_banco, tipoFormatacao,
            AJ_agencia, tipoFormatacao,
            AJ_conta_corrente, tipoFormatacao,
            AJ_numero_card_transacao_original, tipoFormatacao,
            AJ_codigo_bandeira, tipoFormatacao,
            AJ_codigo_produto, tipoFormatacao,
            AJ_valor_taxa_anten, tipoFormatacao,
            AJ_valor_liqui_antec, tipoFormatacao,
            AJ_codigo_pedido, tipoFormatacao,
            AJ_reservado, tipoFormatacao,
            AJ_nseq, tipoFormatacao
            );

        }
        public String CC(String linha)
        {
            CC_codigo_registro = formatter(linha: linha, pos: 1, tam: 2, tipo: "t");
            CC_identificador_loja = formatter(linha: linha, pos: 3, tam: 15, tipo: "t");
            CC_NSU_transacao_orig = formatter(linha: linha, pos: 18, tam: 12, tipo: "t");
            CC_data_transacao_original = formatter(linha: linha, pos: 30, tam: 8, tipo: "d");
            CC_data_transacao_cancelamento = formatter(linha: linha, pos: 37, tam: 8, tipo: "d");
            CC_horaio_transacao_cancelmento = formatter(linha: linha, pos: 46, tam: 6, tipo: "h");
            CC_meio_cap = tabelasAuxiliares.meio_captura(valor: formatter(linha: linha, pos: 52, tam: 1, tipo: "t"));
            CC_bruto_transacao_original = formatter(linha: linha, pos: 53, tam: 11, tipo: "t");
            CC_vaL0_des_comi_cancelamento = formatter(linha: linha, pos: 64, tam: 11, tipo: "m");
            CC_liqui_transacao_original = formatter(linha: linha, pos: 75, tam: 11, tipo: "m");
            CC_numero_parcela = formatter(linha: linha, pos: 86, tam: 2, tipo: "t");
            CC_numero_parc_transacao_original = formatter(linha: linha, pos: 88, tam: 2, tipo: "t");
            CC_nsu_parcela = formatter(linha: linha, pos: 90, tam: 12, tipo: "t");
            CC_valor_bruto_parcela_Cancelemento = formatter(linha: linha, pos: 102, tam: 11, tipo: "m");
            CC_vaL0_liqui_parcela = formatter(linha: linha, pos: 113, tam: 11, tipo: "m");
            CC_codigo_aut_originial = formatter(linha: linha, pos: 124, tam: 12, tipo: "t");
            CC_valot_tax_inter_tarif = formatter(linha: linha, pos: 136, tam: 11, tipo: "m");
            CC_valor_taxa_adm = formatter(linha: linha, pos: 147, tam: 11, tipo: "m");
            CC_valor_taxa_int_tarif_parce = formatter(linha: linha, pos: 158, tam: 11, tipo: "m");
            CC_valor_taxa_adm_parcela = formatter(linha: linha, pos: 169, tam: 11, tipo: "m");
            CC_valor_red_mult_fronteira = formatter(linha: linha, pos: 180, tam: 11, tipo: "m");
            CC_vaL0_taxa_ant = formatter(linha: linha, pos: 191, tam: 11, tipo: "m");
            CC_valor_liquuido_antec = formatter(linha: linha, pos: 202, tam: 11, tipo: "m");
            CC_identificador_envelop = formatter(linha: linha, pos: 213, tam: 18, tipo: "t");
            CC_reservado = formatter(linha: linha, pos: 231, tam: 80, tipo: "t");
            CC_transacao_identificador = formatter(linha: linha, pos: 311, tam: 69, tipo: "t");
            CC_payment_identificador = formatter(linha: linha, pos: 380, tam: 36, tipo: "t");
            CC_identificador_pix = formatter(linha: linha, pos: 416, tam: 36, tipo: "t");
            CC_nseq = formatter(linha: linha, pos: 542, tam: 6, tipo: "t");

           return String.Concat(
                CC_codigo_registro, tipoFormatacao,
                CC_identificador_loja, tipoFormatacao,
                CC_NSU_transacao_orig, tipoFormatacao,
                CC_data_transacao_original, tipoFormatacao,
                CC_data_transacao_cancelamento, tipoFormatacao,
                CC_horaio_transacao_cancelmento, tipoFormatacao,
                CC_meio_cap, tipoFormatacao,
                CC_bruto_transacao_original, tipoFormatacao,
                CC_vaL0_des_comi_cancelamento, tipoFormatacao,
                CC_liqui_transacao_original, tipoFormatacao,
                CC_numero_parcela, tipoFormatacao,
                CC_numero_parc_transacao_original, tipoFormatacao,
                CC_nsu_parcela, tipoFormatacao,
                CC_valor_bruto_parcela_Cancelemento, tipoFormatacao,
                CC_vaL0_liqui_parcela, tipoFormatacao,
                CC_codigo_aut_originial, tipoFormatacao,
                CC_valot_tax_inter_tarif, tipoFormatacao,
                CC_valor_taxa_adm, tipoFormatacao,
                CC_valor_taxa_int_tarif_parce, tipoFormatacao,
                CC_valor_taxa_adm_parcela, tipoFormatacao,
                CC_valor_red_mult_fronteira, tipoFormatacao,
                CC_vaL0_taxa_ant, tipoFormatacao,
                CC_valor_liquuido_antec, tipoFormatacao,
                CC_identificador_envelop, tipoFormatacao,
                CC_reservado, tipoFormatacao,
                CC_transacao_identificador, tipoFormatacao,
                CC_payment_identificador, tipoFormatacao,
                CC_identificador_pix, tipoFormatacao,
                CC_nseq, tipoFormatacao
               ); 

        }
        public String L9(String linha)
        {
            L9_codigo_registro = formatter(linha: linha, pos: 1, tam: 2, tipo: "t");
            L9_total_transacao = formatter(linha: linha, pos: 3, tam: 6, tipo: "t");
            L9_total_valores_cred = formatter(linha: linha, pos: 9, tam: 14, tipo: "m");
            L9_nseq = formatter(linha: linha, pos: 23, tam: 6, tipo: "t");

            return String.Concat(
                L9_codigo_registro, tipoFormatacao,
                L9_total_transacao, tipoFormatacao,
                L9_total_valores_cred, tipoFormatacao,
                L9_nseq, tipoFormatacao
                );

        }
        public String A9(String linha)
        {
            A9_codigo_registro = formatter(linha: linha, pos: 1, tam: 2, tipo: "t");
            A9_total_transacao = formatter(linha: linha, pos: 3, tam: 6, tipo: "t");
            A9_nseq_registroistro = formatter(linha: linha, pos: 9, tam: 6, tipo: "t");

            return String.Concat(
                A9_codigo_registro, tipoFormatacao,
                A9_total_transacao, tipoFormatacao,
                A9_nseq_registroistro, tipoFormatacao
                );
        }

       
        /* m = monetary; t = text; d = date; h = hours */
         String formatter(string linha, int pos, int tam, string tipo)
        {

            switch (tipo)
            {

                case "m":
                    string receivedAmount = linha.Substring(pos-1, tam);
                    string real = receivedAmount.Substring(1, receivedAmount.Length-3);
                    string centavos = receivedAmount.Substring(receivedAmount.Length-2,2);
                    int parseCorrency = Convert.ToInt32(real);
                    string valorFormatado = parseCorrency.ToString("C0", new CultureInfo("pt-BR")) + "," + centavos;
                    return valorFormatado;

                case "t":
                    return linha.Substring(pos-1,tam).Trim();

                case "d":
                    return DateTime.ParseExact(textFormater(linha: linha, pos: pos, tam: tam), "yyyyMMdd", null).ToString("dd/MM/yyyy");

                case "h":
                    string getHours = linha.Substring(pos-1,tam);
                    string hours = getHours.Substring(0,2);
                    string minuts = getHours.Substring(2,2);
                    string seconds = getHours.Substring(4,2);
                    string formatedHours = hours+":"+minuts + ":" +seconds;

                    return formatedHours;
            }

            return "unknow";
        }

        public String textFormater(string linha, int pos, int tam)
        {
            return linha.Substring(pos-1,tam).Trim();
        }
    }
}