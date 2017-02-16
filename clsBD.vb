'--------------------------------------------------------------------------------
' Código gerado pela conversão de VB6 para VB.NET
'--------------------------------------------------------------------------------

#Region "Avisos gerais de conversão"

' CONVERSAO_INFO (#06E1): O projeto atual referencia a biblioteca COM 'ADODB'.

#End Region
Option Strict Off ' Código convertido do VB6 possui Option Strict Off por padrão

Friend Class clsBD

    Public Sub AbreBanco()
        adoCMC7 = New ADODB.Connection()
        adoCMC7.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'adoCMC7.ConnectionString = "PROVIDER=Microsoft.Jet.Oledb.4.0; Persist Security Info=false; Data Source= " & strPath & "bdbancos.mdb"
        adoCMC7.ConnectionString = "Provider=Microsoft.Ace.Oledb.12.0; Persist Security Info=False; Data Source= " & strPath & "bdbancos.mdb"
        adoCMC7.Open()
    End Sub

    Public Sub FechaBanco()
        adoCMC7.Close()
        adoCMC7 = Nothing
    End Sub

    ' CONVERSAO_INFO (#0501): O membro 'CommandText' não é usada em nenhum lugar nessa aplicação.
    Public Sub CommandText(texto As String)
        'rotina que seta os parâmetros do objeto command. Ela recebe o texto do command e o executa
        Dim cmdtexto As ADODB.Command = New ADODB.Command()
        'cmdtexto.ActiveConnection.ConnectionString = adoCMC7.ConnectionString
        cmdtexto.ActiveConnection = adoCMC7
        cmdtexto.CommandType = ADODB.CommandTypeEnum.adCmdText
        cmdtexto.CommandText = texto
        cmdtexto.Execute()
        cmdtexto = Nothing
    End Sub

    Public Function CommandTextRetorna(texto As String) As ADODB.Recordset
        'rotina que seta os parâmetros do objeto command. Ela recebe o texto do command e o executa
        Dim cmdtexto As ADODB.Command = New ADODB.Command()
        'cmdtexto.ActiveConnection.ConnectionString = adoCMC7.ConnectionString
        cmdtexto.ActiveConnection = adoCMC7
        cmdtexto.CommandType = ADODB.CommandTypeEnum.adCmdText
        cmdtexto.CommandText = texto
        CommandTextRetorna = cmdtexto.Execute()
        cmdtexto = Nothing
    End Function

    ' CONVERSAO_INFO (#0501): O membro 'RetornaExistencia' não é usada em nenhum lugar nessa aplicação.
    Public Function RetornaExistencia(SQL As String) As Boolean
        'rotina que verifica se já existe a Chave Primária ou
        'qq dado do banco dependendo da string passada
        Dim rstTexto As ADODB.Recordset = New ADODB.Recordset()

        rstTexto.Open(SQL, adoCMC7, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)

        If rstTexto.BOF And rstTexto.EOF Then
            RetornaExistencia = False
        Else
            RetornaExistencia = True
        End If

        rstTexto.Close()
        rstTexto = Nothing
    End Function

    ' CONVERSAO_INFO (#0501): O membro 'ContaExistencia' não é usada em nenhum lugar nessa aplicação.
    Public Function ContaExistencia(SQL As String) As Integer
        'rotina que conta as Chave Primária ou
        'qq dado do banco dependendo da string passada
        Dim rstTexto As ADODB.Recordset = New ADODB.Recordset()

        rstTexto.Open(SQL, adoCMC7, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)

        If rstTexto.BOF And rstTexto.EOF Then
            ContaExistencia = 0
        Else
            ContaExistencia = rstTexto.RecordCount
        End If

        rstTexto.Close()
        rstTexto = Nothing
    End Function

    ' CONVERSAO_INFO (#0501): O membro 'RetornaTexto' não é usada em nenhum lugar nessa aplicação.
    Public Function RetornaTexto(SQL As String, SoCodigo As Boolean) As String
        'rotina que verifica se já existe a Chave Primária ou
        'qq dado do banco dependendo da string passada
        Dim rstTexto As ADODB.Recordset = New ADODB.Recordset()

        rstTexto.Open(SQL, adoCMC7, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)

        If rstTexto.BOF And rstTexto.EOF Then
            RetornaTexto = ""
        Else

            If SoCodigo Then
                RetornaTexto = rstTexto.Fields(0).Value
            Else
                RetornaTexto = rstTexto.Fields(1).Value & " - " & rstTexto.Fields(0).Value
            End If

        End If

        rstTexto.Close()
        rstTexto = Nothing
    End Function

    Public Function PreencheSQL(strBD As String) As String

        Return "SELECT BD.c_codigo, BD.c_descricao " & "FROM " & strBD & " BD " & "ORDER BY BD.c_descricao"

    End Function

End Class
