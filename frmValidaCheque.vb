'--------------------------------------------------------------------------------
' Código gerado pela conversão de VB6 para VB.NET
'--------------------------------------------------------------------------------

Option Strict Off ' Código convertido do VB6 possui Option Strict Off por padrão

Friend Class frmValidaCheque

    ' CONVERSAO_INFO (#0501): O membro 'Tarja' não é usada em nenhum lugar nessa aplicação.
    Private Tarja As String = ""
    ' CONVERSAO_INFO (#0501): O membro 'ChecaCMC7' não é usada em nenhum lugar nessa aplicação.
    Private ChecaCMC7 As Boolean
    ' CONVERSAO_INFO (#0501): O membro 'MsgErroLog' não é usada em nenhum lugar nessa aplicação.
    Private MsgErroLog As String = ""

    Private Sub cboBanco_KeyPress(ByRef KeyAscii As Short) Handles cboBanco.KeyPress
        If InStr("0123456789", Chr6(KeyAscii)) = 0 And KeyAscii <> 8 Then KeyAscii = 0
    End Sub

    Private Sub cboBanco_KeyUp(ByRef KeyCode As Short, ByRef Shift As Short) Handles cboBanco.KeyUp
        If IsNumeric6(cboBanco.Text) Then Geral.AutoSel(cboBanco, KeyCode)
    End Sub

    Private Sub cmdAreaTransferenciaComCaracteresEspeciais_Click() Handles cmdAreaTransferenciaComCaracteresEspeciais.Click
        Geral.AreaTransferencia(ByVal6(txtBandaMagneticaComCaracteresEspeciais.Text))
    End Sub

    Private Sub cmdAreaTransferenciaSemCaracteresEspeciais_Click() Handles cmdAreaTransferenciaSemCaracteresEspeciais.Click
        Geral.AreaTransferencia(ByVal6(txtBandaMagneticaSemCaracteresEspeciais.Text))
    End Sub

    Private Sub cmdAreaTransferenciaPrimeiraBanda_Click() Handles cmdAreaTransferenciaPrimeiraBanda.Click
        Geral.AreaTransferencia(ByVal6(txtFaixa1.Text))
    End Sub

    Private Sub cmdAreaTransferenciaSegundaBanda_Click() Handles cmdAreaTransferenciaSegundaBanda.Click
        Geral.AreaTransferencia(ByVal6(txtFaixa2.Text))
    End Sub

    Private Sub cmdAreaTransferenciaTerceiraBanda_Click() Handles cmdAreaTransferenciaTerceiraBanda.Click
        Geral.AreaTransferencia(ByVal6(txtFaixa3.Text))
    End Sub

    Private Sub txtAgencia_KeyPress(ByRef KeyAscii As Short) Handles txtAgencia.KeyPress
        If InStr("0123456789", Chr6(KeyAscii)) = 0 And KeyAscii <> 8 Then KeyAscii = 0
    End Sub

    Private Sub txtChequeNumero_KeyPress(ByRef KeyAscii As Short) Handles txtChequeNumero.KeyPress
        If InStr("0123456789", Chr6(KeyAscii)) = 0 And KeyAscii <> 8 Then KeyAscii = 0
    End Sub

    Private Sub txtComp_KeyPress(ByRef KeyAscii As Short) Handles txtComp.KeyPress
        If InStr("0123456789", Chr6(KeyAscii)) = 0 And KeyAscii <> 8 Then KeyAscii = 0
    End Sub

    Private Sub cboTipificacaoCheque_KeyPress(ByRef KeyAscii As Short) Handles cboTipificacaoCheque.KeyPress
        If InStr("0123456789", Chr6(KeyAscii)) = 0 And KeyAscii <> 8 Then KeyAscii = 0
    End Sub

    Private Sub cboTipificacaoCheque_KeyUp(ByRef KeyCode As Short, ByRef Shift As Short) Handles cboTipificacaoCheque.KeyUp
        If IsNumeric6(cboTipificacaoCheque.Text) Then Geral.AutoSel(cboTipificacaoCheque, KeyCode)
    End Sub

    Private Sub txtConta_KeyPress(ByRef KeyAscii As Short) Handles txtConta.KeyPress
        If InStr("0123456789", Chr6(KeyAscii)) = 0 And KeyAscii <> 8 Then KeyAscii = 0
    End Sub

    Private Sub Form_Load() Handles MyBase.Load
        On Error GoTo TrataErro
        'Dimensiona as RecordSets
        Dim rsBD As ADODB.Recordset = New ADODB.Recordset()
        Dim rsTCheque As ADODB.Recordset

        'Limpa a ComboBox
        cboBanco.Clear()

        'Instancia "Class Module" clsBD
        BD = New clsBD()

        'Instacia a Conexão ao Banco de Dados
        adoCMC7 = New ADODB.Connection()

        'Abrir banco
        BD.AbreBanco()

        'Instancia a RecordSet rsBD
        strSQL = BD.PreencheSQL("tbl_bancos")
        rsBD = BD.CommandTextRetorna(strSQL)

        'Carregar Base de Dados de "Bancos" na ComboBox
        Do While rsBD.EOF = False
            cboBanco.AddItem(rsBD.Fields("c_codigo").Value & " - " & rsBD.Fields("c_descricao").Value)
            cboBanco.ItemData(cboBanco.ListCount - 1) = rsBD.Fields("c_codigo").Value
            rsBD.MoveNext()
        Loop

        'Destruir a instância
        rsBD = Nothing

        'Limpa a ComboBox
        cboTipificacaoCheque.Clear()

        'Instancia a RecordSet rsBD
        rsTCheque = New ADODB.Recordset()
        strSQL = BD.PreencheSQL("tbl_tipificacaoCheque")
        rsTCheque = BD.CommandTextRetorna(strSQL)

        'Carregar Base de Dados de "Tipificação de Cheque" na ComboBox
        Do While rsTCheque.EOF = False
            cboTipificacaoCheque.AddItem(rsTCheque.Fields("c_codigo").Value & " - " & rsTCheque.Fields("c_descricao").Value)
            cboTipificacaoCheque.ItemData(cboTipificacaoCheque.ListCount - 1) = rsTCheque.Fields("c_codigo").Value
            rsTCheque.MoveNext()
        Loop

        BD.FechaBanco()

        cmdLimparCampos_Click()

        Exit Sub

TrataErro:
        MsgBox6("Ocorreu um erro!", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "ERRO")

    End Sub

    Private Sub cmdLimparCampos_Click() Handles cmdLimparCampos.Click
        On Error GoTo TrataErro

        'Primeira Banda
        txtFaixa1.Text = ""
        cboBanco.ListIndex = -1
        cboBanco.Text = ""
        txtAgencia.Text = ""
        txtBandaDg2.Text = ""

        'Segunda Banda:
        txtFaixa2.Text = ""
        txtComp.Text = ""
        txtChequeNumero.Text = ""
        cboTipificacaoCheque.ListIndex = 2 '5 - Comum

        'Terceira Banda:
        txtFaixa3.Text = ""
        txtBandaDg1.Text = ""
        txtConta.Text = ""
        txtBandaDg3.Text = ""

        'Banda Magnética:
        txtBandaMagneticaComCaracteresEspeciais.Text = ""
        txtBandaMagneticaSemCaracteresEspeciais.Text = ""
        Exit Sub

TrataErro:
        MsgBox6("Ocorreu um erro!", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "ERRO")

    End Sub

    Private Sub cmdCalcular_Click() Handles cmdCalcular.Click

        'Validar a combo "cboBanco"
        If cboBanco.ListIndex = -1 Then
            MsgBox6("Por favor, escolha um Banco.", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "BANCO")
            cboBanco.Text = ""
            cboBanco.SetFocus()
            Exit Sub
        End If

        'Validar a combo "cboTipificacaoCheque"
        If cboTipificacaoCheque.ListIndex = -1 Then
            MsgBox6("Por favor, escolha um Tipo de Cheque.", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "TIPIFICAÇÃO DO CHEQUE")
            cboTipificacaoCheque.Text = ""
            cboTipificacaoCheque.SetFocus()
            Exit Sub
        End If

        'Instancia a "Class Module" clsModulo
        modul = New clsModulo()

        'Acerta se cada campo está no tamanho correto
        AcertaTamanhoCampo()

        txtFaixa1.Text = Format6(cboBanco.ItemData(cboBanco.ListIndex), "000") & txtAgencia.Text
        txtFaixa2.Text = txtComp.Text & txtChequeNumero.Text & cboTipificacaoCheque.ItemData(cboTipificacaoCheque.ListIndex)
        txtFaixa3.Text = txtConta.Text

        '1 - Calcular PRIMEIRO o dígito Verificar do Segunda Banda!
        'txtBandaDg2.Text = modul.Modulo10(txtFaixa2.Text)
        'txtBandaDg2.Text = modul.MOD10(txtFaixa2.Text)
        'txtBandaDg2.Text = modul.DV_MOD10(txtFaixa2.Text)
        txtBandaDg2.Text = modul.Dig_Base10(ByVal6(txtFaixa2.Text))

        '2 - Fazer a Primeira Banda
        'txtBandaDg1.Text = modul.Modulo10(txtFaixa1.Text)
        'txtBandaDg1.Text = modul.MOD10(txtFaixa1.Text)
        'txtBandaDg1.Text = modul.DV_MOD10(txtFaixa1.Text)
        txtBandaDg1.Text = modul.Dig_Base10(ByVal6(txtFaixa1.Text))

        '3 - Fazer a terceira Banda
        'txtBandaDg3.Text = modul.DV_MOD10(Format(txtFaixa3.Text, "0000000000"))
        txtBandaDg3.Text = modul.DV_MOD10(ByVal6(txtFaixa3.Text))

        'Colocando os dígitos nas faixas (Somente faixas 1 e 3):
        txtFaixa1.AppendText(txtBandaDg2.Text)
        txtFaixa1.Text = Format6(txtFaixa1.Text, "00000000")

        txtFaixa3.Text = txtBandaDg1.Text & txtFaixa3.Text & txtBandaDg3.Text

        MontaBandaMagnetica()
    End Sub

    Private Sub AcertaTamanhoCampo()
        txtAgencia.Text = Geral.AcertaCodigo(txtAgencia.Text, 4, "0")
        txtComp.Text = Geral.AcertaCodigo(txtComp.Text, 3, "0")
        txtChequeNumero.Text = Geral.AcertaCodigo(txtChequeNumero.Text, 6, "0")
        txtConta.Text = Geral.AcertaCodigo(txtConta.Text, 10, "0")
    End Sub

    Private Sub MontaBandaMagnetica()
        '======================================================
        'http://www.devmedia.com.br/forum/layout-cheque/285633
        '======================================================
        'Pessoal dei uma lida num artigo do Aroldo Zanela sobre layout da banda magnética, mas to com muitas dúvidas. Por exemplo eu tenho um cheque com os seguintes dados( Banco do Brasil)
        '
        'Comp:001
        'Banco:001
        'Agencia:0005
        'DV:1
        'C1:8
        'Conta:0016864-5
        'C2:3
        'Série:001
        'Cheque Nº:218917
        'C3:8
        '
        'E a banda magnética da seguinte maneira:
        '<00100058<0012189175<704001686452>
        '
        'Não batem os campos, alguem se habilita?
        '
        'Daniel Miranda Cruz

        ' ----- ATENÇÃO!!! ------------------ EXPLICAÇÃO!!!

        'E a banda magnética da seguinte maneira:
        '<00100058<0012189175<704001686452>

        '<001 = banco
        '0005 = agência
        '8 = dv2
        '<001 = câmara de compensação (comp)
        '218917 = número do cheque
        '5 = tipificação ( 5 normal, 6 bancário, 7 salário, 8 administrativo, etc)
        '>7 = dv1
        '0400168645 = número da conta (*)
        '2> = dv3

        '*No número da conta do BB é colocado 2 dígitos para identificar o tipo de conta, neste caso 04. Esta é única diferença entre a banda magnética e a linha superior.

        'Outros bancos:
        'Itaú, eles colocam 4 dígitos, que é diferente para cada cheque do talão.
        'Unibanco faz o mesmo, porém são 3 dígitos.
        'Bradesco: número fixo 775.

        'A conta da banda magnética possui tem 10 caracteres, atualmente os bancos estão utilizando parte da conta para colocar mais segurança, como o Itaú que criou mais 4 dvs e colocou nas 4 primeiras posições do número da conta.

        '======================================================
        'mais detalhes,
        'http://www.veloso.adm.br
        '======================================================

        txtBandaMagneticaComCaracteresEspeciais.Text = "<" & Format6(cboBanco.ItemData(cboBanco.ListIndex), "000") & txtAgencia.Text & txtBandaDg2.Text & "<" & txtComp.Text & txtChequeNumero.Text & cboTipificacaoCheque.ItemData(cboTipificacaoCheque.ListIndex) & ">" & txtBandaDg1.Text & txtConta.Text & txtBandaDg3.Text & ">"

        txtBandaMagneticaSemCaracteresEspeciais.Text = Format6(cboBanco.ItemData(cboBanco.ListIndex), "000") & txtAgencia.Text & txtBandaDg2.Text & txtComp.Text & txtChequeNumero.Text & cboTipificacaoCheque.ItemData(cboTipificacaoCheque.ListIndex) & txtBandaDg1.Text & txtConta.Text & txtBandaDg3.Text

        '------------------------------------------------------------------------------
        'CMC7 CERTO
        '001254090180032515170010446428
        '------------------------------------------------------------------------------
    End Sub

    Private Sub cmdExemplo1_Click() Handles cmdExemplo1.Click
        '======================================================
        'Exemplo que funciona:
        'http://www.veloso.adm.br/leiautecmc7.html
        '======================================================
        '-------------------------------------------
        'CMC7 - exemplo:
        '<23731842<0010034895>777504362409>
        '-------------------------------------------
        'a - 237        - Número do Banco
        'b - 3184       - Número da Agência
        'c - 2          - Dígito verificador da Comp+Cheque+Tipificação
        'd - 001        - Comp (câmara de compensação - 018-SP, 001-RJ, etc)
        'e - 003489     - Número do cheque
        'f - 5          - Tipificação(5-Comum 6-Bancário 7-Salário 8-Administr. 9-CPMF)
        'g - 7          - Dígito verificador do Banco+Agência
        'h - 7750436240 - Número da Conta
        'i - 9          - Dígito verificador da Conta*
        '* O Dv da Conta no CMC7 não tem nada haver com o Dv da Conta na Linha1, este inclusive faz parte do número da conta no CMC7.
        '-------------------------------------------

        cmdLimparCampos_Click()
        cboBanco.ListIndex = 20 'a '237 - BANCO BRADESCO S.A.
        txtAgencia.Text = "3184" 'b
        txtComp.Text = "001" 'd
        txtChequeNumero.Text = "003489" 'e
        cboTipificacaoCheque.ListIndex = 2 'f '5 - Comum
        txtConta.Text = "7750436240" 'h
        cmdCalcular_Click()
    End Sub

    Private Sub cmdExemplo2_Click() Handles cmdExemplo2.Click
        '-------------------------------------------
        'Exemplo que funciona:
        'http://www.fesppr.br/~erico/x%202009%20ASIG/2009%20-%20sala%20305/Trabalho%20CMC7_%20Cristiane%20Faria,%20Fernanda,%20Ana%20Paula,%20Francine%20e%20Tatiane.pdf
        '-------------------------------------------
        'Os separadores dividem o CMC7 em três bandas. Exemplo:
        'Primeira Banda     Segunda Banda   Terceira Banda
        '23704948           0180017935      377506100112
        '-------------------------------------------
        'Primeira Banda - 237 0494 8
        '237 Código do Banco
        '0494 Código da Agência
        '8 Dígito verificador da Segunda Banda
        '-------------------------------------------
        'Segunda Banda - 018 001793 5
        '018 Código da câmara de Compensação
        '001793 Número do cheque
        '5 - Tipificação do cheque (5 – Comum 6-Bancário 7 – Salário 8–Administrativo 9 – CPMF)
        '-------------------------------------------
        'Terceira Banda - 3 7750610011 2
        '3 Dígito verificador da primeira banda
        '7750610011 Número da Conta
        '2 Dígito verificador da terceira banda
        '-------------------------------------------

        cmdLimparCampos_Click()
        cboBanco.ListIndex = 20 '237 - BANCO BRADESCO S.A.
        txtAgencia.Text = "0494"
        txtComp.Text = "018"
        txtChequeNumero.Text = "001793"
        cboTipificacaoCheque.ListIndex = 2 '5 - Comum
        txtConta.Text = "7750610011"
        cmdCalcular_Click()
    End Sub

    Private Sub cmdExemplo3_Click() Handles cmdExemplo3.Click
        '-------------------------------------------
        'Primeira Banda
        '001 - Código do Banco
        '0005 - Código da Agência
        '8 - Dígito Verificador da Segunda Banda
        '-------------------------------------------
        'Segunda Banda
        '001 - Código da Câmara de Compensação
        '218917 - Número do Cheque
        '5 - Tipificação do Cheque (5–Comum 6–Bancário 7–Salário 8–Administrativo 9–CPMF)
        '-------------------------------------------
        'Terceira Banda
        '7- Dígito verificador da Primeira Banda
        '0400168645 - Número da Conta Corrente
        '2 - Dígito verificador da Terceira Banda
        '-------------------------------------------

        cmdLimparCampos_Click()
        cboBanco.ListIndex = 38 '001 - BANCO DO BRASIL S.A.
        txtAgencia.Text = "0005"
        txtComp.Text = "001"
        txtChequeNumero.Text = "218917"
        cboTipificacaoCheque.ListIndex = 2 '5 - Comum
        txtConta.Text = "0400168645"
        cmdCalcular_Click()
    End Sub

End Class
