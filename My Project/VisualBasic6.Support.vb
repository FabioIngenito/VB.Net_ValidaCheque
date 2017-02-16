Imports System.Diagnostics
Imports System.Reflection
Imports System.Resources
Imports System.Runtime.InteropServices

Friend Module VisualBasic6_Support

#Region "Inicializacao"

    ' Constantes para o objeto App6
    Public Const APP6_HELPFILE As String = ""
    Public Const APP6_HELPCONTEXTID As Integer = 0
    Public Const APP6_TITLE As String = ""
    Private Const APP6_UNIQUEID As Long = 838115142           ' <== nao modifique!

    ' Inicializa a biblioteca de suporte VB6
    Sub New()
        ' Descomente a proxima linha para pular a busca de assembly a inicializacao
        ' VBLibrary.VB6Config.ParseAssembliesAtStartup = False
        VBLibrary.InitializeLibrary(System.Windows.Forms.Application.OpenForms, My.Application.Info, APP6_HELPFILE, APP6_HELPCONTEXTID, APP6_UNIQUEID)
        ' A proxima linha pode ser comentada se a aplicacao nao utiliza DDE
        VBLibrary.VB6Config.DDEAppTitle = APP6_TITLE

    End Sub

    Public Sub EnsureVB6LibraryInitialization()
        ' A razao desse metodo vazio e para forcar a execucao do construtor
        ' estatico na primeira vez que o metodo for chamado
    End Sub

#End Region

#Region "Objetos globais"

    ' Objeto App6
    Private _app6 As VB6App
    Public ReadOnly Property App6() As VB6App
        Get
            If _app6 Is Nothing Then
                _app6 = New VB6App(Assembly.GetExecutingAssembly(), My.Application.Info)
            End If
            Return _app6
        End Get
    End Property

    ' Objeto Screen6
    Private _screen6 As VB6Screen
    Public ReadOnly Property Screen6() As VB6Screen
        Get
            If _screen6 Is Nothing Then
                _screen6 = New VB6Screen(Assembly.GetExecutingAssembly())
            End If
            Return _screen6
        End Get
    End Property

    ' Colecao Forms6
    Private _forms6 As VB6Forms
    Public ReadOnly Property Forms6() As VB6Forms
        Get
            If _forms6 Is Nothing Then
                _forms6 = New VB6Forms(Assembly.GetExecutingAssembly(), System.Windows.Forms.Application.OpenForms)
            End If
            Return _forms6
        End Get
    End Property

    ' Objeto Printer6
    Private _printer6 As VB6Printer
    Public Property Printer6() As VB6Printer
        Get
            If _printer6 Is Nothing Then
                _printer6 = New VB6Printer
            End If
            Return _printer6
        End Get
        Set(value As VB6Printer)
            If value Is Nothing Then
                Throw New ArgumentException("Printer nao pode ser Nothing")
            End If
            If _printer6 Is value Then
                Exit Property
            End If
            _printer6 = value
            ' Limpa a propriedade PrinterObject para forcar a aperacao com Graphics
            value.PrinterObject = Nothing
        End Set
    End Property

    ' Colecao Printers6
    Private _printers6 As VB6Printers
    Public ReadOnly Property Printers6() As VB6Printers
        Get
            If _printers6 Is Nothing Then
                _printers6 = New VB6Printers()
            End If
            Return _printers6
        End Get
    End Property

#End Region

#Region "Suporte a resources"

    ' Suporte para leitura de resources
    Dim _resourceMan As ResourceManager = New Global.System.Resources.ResourceManager(GetType(VisualBasic6_Support).Namespace & ".Resources", GetType(VisualBasic6_Support).Assembly)

    Public Function LoadResString6(id As Object) As String
        Return DirectCast(GetResourceFromID("str", id), String)
    End Function

    Public Function LoadResPicture6(id As Object, resType As Integer) As Object
        Dim prefix As String = Microsoft.VisualBasic.Choose(resType + 1, "bmp", "ico", "cur")
        Return GetResourceFromID(prefix, id)
    End Function

    Public Function LoadResData6(id As Object, resType As Object) As Object
        Dim prefix As String = "?"
        If TypeOf resType Is String Then
            prefix = resType.ToString() & "_"
        ElseIf IsNumeric(resType.ToString()) Then
            prefix = Microsoft.VisualBasic.Choose(CInt(resType), "cur", "bmp", "ico", "?", "?", "str")
        End If
        Return GetResourceFromID(prefix, id)
    End Function

    ' Extrai o resource, caso constrario dispara uma excecao
    Private Function GetResourceFromID(prefix As String, id As Object) As Object
        ' Certifica-se de que o ID nao contem caracteres invalidos
        Dim strId As String = System.Text.RegularExpressions.Regex.Replace(id.ToString(), "[^A-Za-z0-9_.]", "_")
        Dim res As Object = _resourceMan.GetObject(prefix & strId, Nothing)
        If res IsNot Nothing Then
            Select Case prefix
                Case "str" : If Not TypeOf res Is String Then res = Nothing
                Case "bmp" : If Not TypeOf res Is System.Drawing.Image Then res = Nothing
                Case "ico" : If Not TypeOf res Is System.Drawing.Image AndAlso Not TypeOf res Is Icon Then res = Nothing
                Case "cur" : If Not TypeOf res Is Cursor Then res = Nothing
            End Select
        Else
            ' tenta novamente com ID em maiusculo
            res = _resourceMan.GetObject(prefix.ToUpper() & strId, Nothing)
        End If
        ' Verifica se o resource esta faltando ou se e tipo invalido
        If res Is Nothing Then
            Err.Raise(326, , "Resource com o identificador '" & strId & "' nao encontrado")
        End If
        Return res
    End Function

#End Region

#Region "Suporte a debug"

    <Conditional("DEBUG")>
    Public Sub DebugPrintLine6(ParamArray args() As Object)
        VBLibrary.DebugPrintLine6(args)
    End Sub

    <Conditional("DEBUG")>
    Public Sub DebugPrint6(ParamArray args() As Object)
        VBLibrary.DebugPrint6(args)
    End Sub

#End Region

End Module

