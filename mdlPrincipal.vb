'--------------------------------------------------------------------------------
' Código gerado pela conversão de VB6 para VB.NET
'--------------------------------------------------------------------------------

Option Strict Off ' Código convertido do VB6 possui Option Strict Off por padrão

Friend Module mdlPrincipal

    Public strPath As String = ""
    Public strSQL As String = ""

    'Dimensiona a Conexão ao Banco de Dados
    Public adoCMC7 As ADODB.Connection

    'Dimensiona as "Class Module"
    Public BD As clsBD
    Public modul As clsModulo

    'Dimensiona e Instancia a "Class Module"
    Public Geral As New clsGeral

#Region "Static constructor"

    ' Este construtor estatico serve para garantir a inicializacao da VBLibrary.
    Sub New()
        EnsureVB6LibraryInitialization()
    End Sub

#End Region

    <STAThread()>
    Public Sub Main()
        Application.EnableVisualStyles()
        strPath = App6.Path & "\"

        frmValidaCheque.Show()
    End Sub

    '=====================================================
    'http://www.veloso.adm.br/artigocmc7.asp ... saiu do ar ... pena!
    '=====================================================

    'Dúvidas sobre cadastramento de cheques em programas

    'O que é Linha1 do Cheque?
    'É a parte superior do cheque onde tem os dados, na ordem:
    ' |Comp | Banco | agência |C1| Conta |C2| |Cheque|C3| R$ |

    'Para que serve a linha1?
    'Serve para digitação do cheque em sistemas quando não for
    ' possível digitar o CMC7.

    'O que é CMC7 do Cheque?
    'CMC7 significa Caracteres Magnéticos Codificados em 7 barras.
    'Também é chamada de banda magnética ou linha2 do cheque.
    ' É apenas mais um padrão de código de barras, porém com uma
    ' particularidade, a impressão tem que ser com toner magnético.
    'Além da impressão com toner magnético, outra forma de dificultar
    ' a falsificação é a validação dos 3 dígitos verificadores
    ' contidos no CMC7.

    'Os separadores dividem o CMC7 em três bandas.
    'Ex:
    'Primeira Banda Segunda Banda Terceira Banda
    '23704948       0180017935    377506100112

    'A validação do CMC7 é padrão para todos os bancos?
    'Sim. Não há uma nova regra para validação do CMC7, também a
    ' validação não depende do banco, esta regra é da Febraban.
    ' A alteração desta regra afetaria muitos sistemas.
    'Por Favor, não telefone ou envie e-mail perguntando sobre
    ' alteração.

    'Porque o número da conta alguns de bancos é diferente na Linha1
    ' e CMC7 ?
    'Isto ocorre porque alguns bancos aproveitam algumas posições da
    ' conta do CMC7 para colocarem números que não teriam espaço no
    ' CMC7, estes números não estão na conta da Linha1.
    'Estes números são chamados de 'Razão' da conta.

    'Os campos C1, C2 e C3 estão no CMC7 ?
    'Não, os campos C1, C2 e C3 são dígitos de controle para digitação
    ' da linha1. Os dígitos de controle do CMC7 também são 3 porém
    ' calculados de forma diferente.

    'Porque o componente TCMC7 retorna a conta do banco diferente da
    ' linha1 do cheque ?
    'O objetivo principal do componente TCMC7 é validar o CMC7 e a
    ' Linha1, ele faz isto através dos 3 dígitos da Linha1 (C1,C2, e C3)
    ' e dos 3 dígitos do CMC7.
    'O componente tem uma função para retornar a conta do CMC7, porém
    ' sempre retornará 10 caracteres referentes ao número da conta do CMC7.
    'Isto não impede que seja feita um função para tratar este número
    ' de conta, isto não é feito no componente porque não existe uma
    ' regra padronizada.

    'Quando fizer o cadastramento do cheque através do CMC7 tenho que
    ' mudar o número da conta ?
    'Se for gerar arquivo de compensação para banco tipo CNAB240 não
    ' há necessidade, pois neste tipo de arquivo você fornece o CMC7
    ' inteiro com foi capturado ou a Linha1 como foi digitada.
    'Agora para guardar na sua base de dados, o melhor seria mudar o
    ' número da conta para bancos que utilizam a RAZÃO da conta.

    'exemplo:  Itaú
    'Conta na Linha1: 23288-2
    'Conta no CMC7: 7123232882
    '(7123=número que muda para cada folha do cheque)
    '(232882 = número da conta)

    'Então, se você utilizar o número da conta para buscar dados em
    ' outras tabelas, não vai funcionar pois o número sempre será
    ' diferente.
    'Neste caso você deveria retirar o 7123, 4 primeiras posições,
    ' antes de fazer a pesquisa.

    'É possível transformar a linha1 em CMC7 e vice-versa ?
    'Não. Os Bancos criaram o campo razão para dificultar isto.
    ' O campo razão esta marcado com asterísco no CMC7 abaixo, varia
    ' de tamanho conforme o banco. A regra para criação da razão não
    ' existe padronização ou legislação e portanto é um segredo de
    ' cada banco.

End Module
