'--------------------------------------------------------------------------------
' Código gerado pela conversão de VB6 para VB.NET
'--------------------------------------------------------------------------------
'A conversão foi feita por um software de EHASIS - Edison Henrique Andreassy <ehasis@hotmail.com>
'Tópico no VBMania para o VB6:
'http://www.vbmania.com.br/index.php?modulo=detalhe&id=9403

Option Strict Off ' Código convertido do VB6 possui Option Strict Off por padrão

Imports VB = Microsoft.VisualBasic

Friend Class clsGeral

    ' CONVERSAO_INFO (#0501): O membro 'LimpaCampos' não é usada em nenhum lugar nessa aplicação.
    Public Sub LimpaCampos(frm As VB6Form)
        'Coloca um espaço em branco em todas as caixas de texto do formulário
        Dim obj As Object = Nothing

        For Each obj In frm.Controls6

            If (TypeOf obj Is VB6TextBox) Or (TypeOf obj Is VB6ComboBox) Then 'Or (TypeOf obj Is MaskEdBox) Then
                obj.Text = ""
                'ElseIf TypeOf obj Is DTPicker Then
                '   obj.Value = Now
            End If

        Next

    End Sub

    ' CONVERSAO_INFO (#0501): O membro 'ConfiguraBotoes' não é usada em nenhum lugar nessa aplicação.
    ' CONVERSAO_INFO (#0551): O parâmetro 'trava' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    Public Sub ConfiguraBotoes(frm As VB6Form, ByRef trava As Boolean)
        'Configura Enable em todas os botões do formulário
        Dim obj As Object = Nothing

        For Each obj In frm.Controls6

            If (TypeOf obj Is VB6CommandButton) Then
                obj.Enabled = trava
            End If

        Next

    End Sub

    ' CONVERSAO_INFO (#0501): O membro 'ConfiguraCampos' não é usada em nenhum lugar nessa aplicação.
    ' CONVERSAO_INFO (#0551): O parâmetro 'trava' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    ' CONVERSAO_INFO (#0551): O parâmetro 'cor' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    Public Sub ConfiguraCampos(frm As VB6Form, ByRef trava As Boolean, ByRef cor As System.Drawing.Color)
        'Configura Locked e ForeColor em todas as caixas de texto do formulário
        Dim obj As Object = Nothing

        For Each obj In frm.Controls6

            If (TypeOf obj Is VB6TextBox) Or (TypeOf obj Is VB6ComboBox) Then
                obj.ForeColor = ToOleColor6(cor)
                obj.Locked = trava
                'ElseIf TypeOf obj Is MaskEdBox Then
                '   obj.ForeColor = cor
                '   obj.Enabled = Not trava
                'ElseIf TypeOf obj Is DTPicker Then
                '   obj.CalendarForeColor = cor
                '   obj.CalendarTitleForeColor = cor
            End If

        Next

    End Sub

    ' CONVERSAO_INFO (#0501): O membro 'TrataApostrofe' não é usada em nenhum lugar nessa aplicação.
    Public Function TrataApostrofe(strTexto As String) As String
        Dim intPosicao As Short = 1
        Dim intLocal As Short = InStr(intPosicao, strTexto, "'")

        strTexto = Trim(strTexto)

        Do While intPosicao <= intLocal
            ' CONVERSAO_INFO (#0571): Concatenação de string dentro de um loop. Considere declarar a variável 'TrataApostrofe' como um objeto AutoStringBuilder.
            TrataApostrofe = TrataApostrofe & Mid(strTexto, intPosicao, intLocal - intPosicao + 1) & "'"
            intPosicao = intLocal + 1
            intLocal = InStr(intPosicao, strTexto, "'")
        Loop

        Return TrataApostrofe & Mid(strTexto, intPosicao)
    End Function

    ' CONVERSAO_INFO (#0501): O membro 'F_Centraliza' não é usada em nenhum lugar nessa aplicação.
    ' CONVERSAO_INFO (#0561): O símbolo 'F_Centraliza' foi definido sem o uso explícito da cláusula "As".
    Public Function F_Centraliza(Formulario As VB6Form) As Object
        Formulario.Left = (Screen6.Width - Formulario.Width) / 2
        Formulario.Top = (Screen6.Height - Formulario.Height) / 2 - 1080
    End Function

    Public Function AcertaCodigo(strCodigo As String, intTamanho As Short, strCaracter As String) As String
        strCodigo = VB.Right(strCodigo, intTamanho)
        Return String6(intTamanho - Len6(strCodigo), strCaracter) & strCodigo
    End Function

    ' CONVERSAO_INFO (#0501): O membro 'PoeAspa' não é usada em nenhum lugar nessa aplicação.
    ' CONVERSAO_INFO (#0551): O parâmetro 'strString' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    ' CONVERSAO_INFO (#0551): O parâmetro 'strTipo' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    Public Function PoeAspa(ByRef strString As String, ByRef strTipo As String) As String

        If strTipo = "A" Then
            Return "'" & strString & "'"
        Else
            Return strString
        End If

    End Function

    ' CONVERSAO_INFO (#0501): O membro 'PegaAposTraco' não é usada em nenhum lugar nessa aplicação.
    ' CONVERSAO_INFO (#0551): O parâmetro 'strTexto' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    Public Function PegaAposTraco(ByRef strTexto As String) As String

        If Not strTexto = "" Then
            Return VB.Right(strTexto, Len6(strTexto) - InStrRev(strTexto, "-") - 1)
        End If

    End Function

    ' CONVERSAO_INFO (#0501): O membro 'PegaAposTraco2' não é usada em nenhum lugar nessa aplicação.
    ' CONVERSAO_INFO (#0551): O parâmetro 'strTexto' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    Public Function PegaAposTraco2(ByRef strTexto As String) As String
        Dim arrPalavra() As String
        ' O mesmo retorno que o PegaAposTraço mas de uma outra maneira ... by Neusa

        If Not strTexto = "" Then
            arrPalavra = Split6(strTexto, "-")
            Return Trim(arrPalavra(1))
        End If

    End Function

    'Função para colocar o ENTER como TAB
    ' CONVERSAO_INFO (#0501): O membro 'TabXEnter' não é usada em nenhum lugar nessa aplicação.
    Public Sub TabXEnter(ByRef Key As Short)
        If Key = 13 Then Key = 0: My.Computer.Keyboard.SendKeys("{TAB}")
    End Sub

    'Função que ajuda a preencher uma ComboBox
    ' CONVERSAO_INFO (#0561): O símbolo 'AutoSel' foi definido sem o uso explícito da cláusula "As".
    ' CONVERSAO_INFO (#0551): O parâmetro 'Cmb' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    ' CONVERSAO_INFO (#0551): O parâmetro 'KeyCode' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    Public Function AutoSel(ByRef Cmb As VB6ComboBox, ByRef KeyCode As Short) As Object
        Dim Text As String = ""
        Dim i As Integer
        Dim Temp As String = ""

        'Debug.Print KeyCode

        If KeyCode = VBRUN.DragOverConstants.vbEnter Then Exit Function
        If KeyCode = 8 Then Exit Function 'Backspace
        If KeyCode = 37 Then Exit Function 'left key
        If KeyCode = 38 Then Exit Function 'up arrow key
        If KeyCode = 39 Then Exit Function 'right key
        If KeyCode = 40 Then Exit Function 'down arrow key
        If KeyCode = 46 Then Exit Function 'delete key
        If KeyCode = 33 Then Exit Function 'page up key
        If KeyCode = 34 Then Exit Function 'page down key
        If KeyCode = 35 Then Exit Function 'end key
        If KeyCode = 36 Then Exit Function 'home key

        Text = Cmb.Text

        For i = 0 To Cmb.ListCount - 1
            Temp = VB.Left(Cmb.List(i), Len6(Text))

            If LCase(Temp) = LCase(Text) Then
                Cmb.Text = Cmb.List(i)
                Cmb.ListIndex = i
                Cmb.SelStart = Len6(Text)
                Cmb.SelLength = Len6(Cmb.List(i))
                'Cmb.SetFocus
            End If

        Next

    End Function

    'http://www.macoratti.net/d250902.htm
    'Copiar para área de transferência
    ' CONVERSAO_INFO (#0551): O parâmetro 'txt' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.

    ' O default no VB6 é "ByRef" (Por Referência) e no VB.Net o default é "ByVal" (Por Valor) (nem precisa digitar "ByVal", mas fica o exemplo).
    'Public Sub AreaTransferencia(ByRef txt As String)

    'Consulte também: "Escolha do mecanismo de passagem"
    'https://msdn.microsoft.com/pt-br/library/ddck1z30.aspx

    Public Sub AreaTransferencia(ByVal txt As String)
        Clipboard6.Clear() ' limpa o ClibBoard

        'Na conversão de VB6 para VB.Net precisei fazer o tratamento de "Empty" aqui:
        If Not String.IsNullOrEmpty(txt) Then _
            Clipboard6.SetText(txt) ' Poe o texto no ClipBoard
    End Sub

End Class
