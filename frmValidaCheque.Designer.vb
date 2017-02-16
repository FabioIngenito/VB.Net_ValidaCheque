<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmValidaCheque
    Inherits VBLibrary.VB6Form

    
#Region "Static constructor"
    
    ' Este construtor estatico serve para garantir a inicializacao da VBLibrary.
    Shared Sub New()
        EnsureVB6LibraryInitialization()
    End Sub
    
#End Region
    
#Region "Windows Form Designer generated code "

    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'Create all controls and control arrays.
        InitializeComponents()
    End Sub

    ' This method wraps the call to InitializeComponent, but can be called from base class.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub InitializeComponents()
        Me.ObjectIsInitializing = True
        InitializeComponent()
        Me.ObjectIsInitializing = False
    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then
                If components IsNot Nothing Then components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public WithEvents cmdAreaTransferenciaTerceiraBanda As VBLibrary.VB6CommandButton
    Public WithEvents cmdAreaTransferenciaSegundaBanda As VBLibrary.VB6CommandButton
    Public WithEvents cmdAreaTransferenciaPrimeiraBanda As VBLibrary.VB6CommandButton
    Public WithEvents cmdAreaTransferenciaSemCaracteresEspeciais As VBLibrary.VB6CommandButton
    Public WithEvents cmdAreaTransferenciaComCaracteresEspeciais As VBLibrary.VB6CommandButton
    Public WithEvents txtBandaMagneticaSemCaracteresEspeciais As VBLibrary.VB6TextBox
    Public WithEvents cboBanco As VBLibrary.VB6ComboBox
    Public WithEvents cmdLimparCampos As VBLibrary.VB6CommandButton
    Public WithEvents cmdExemplo3 As VBLibrary.VB6CommandButton
    Public WithEvents txtBandaMagneticaComCaracteresEspeciais As VBLibrary.VB6TextBox
    Public WithEvents cmdExemplo2 As VBLibrary.VB6CommandButton
    Public WithEvents cmdExemplo1 As VBLibrary.VB6CommandButton
    Public WithEvents cboTipificacaoCheque As VBLibrary.VB6ComboBox
    Public WithEvents txtBandaDg3 As VBLibrary.VB6TextBox
    Public WithEvents txtBandaDg2 As VBLibrary.VB6TextBox
    Public WithEvents txtBandaDg1 As VBLibrary.VB6TextBox
    Public WithEvents cmdCalcular As VBLibrary.VB6CommandButton
    Public WithEvents txtFaixa3 As VBLibrary.VB6TextBox
    Public WithEvents txtFaixa2 As VBLibrary.VB6TextBox
    Public WithEvents txtFaixa1 As VBLibrary.VB6TextBox
    Public WithEvents txtChequeNumero As VBLibrary.VB6TextBox
    Public WithEvents txtConta As VBLibrary.VB6TextBox
    Public WithEvents txtAgencia As VBLibrary.VB6TextBox
    Public WithEvents txtComp As VBLibrary.VB6TextBox
    Public WithEvents lblBandaMagneticaSemCarcteresEspeciais As VBLibrary.VB6Label
    Public WithEvents Image1 As VBLibrary.VB6Image
    Public WithEvents Line6 As VBLibrary.VB6Line
    Public WithEvents lblBandaMagneticaComCarcteresEspeciais As VBLibrary.VB6Label
    Public WithEvents Line5 As VBLibrary.VB6Line
    Public WithEvents Line3 As VBLibrary.VB6Line
    Public WithEvents Line4 As VBLibrary.VB6Line
    Public WithEvents Line2 As VBLibrary.VB6Line
    Public WithEvents Line1 As VBLibrary.VB6Line
    Public WithEvents lblTerceiraBanda As VBLibrary.VB6Label
    Public WithEvents lblSegundaBanda As VBLibrary.VB6Label
    Public WithEvents lblPrimeiraBanda As VBLibrary.VB6Label
    Public WithEvents lblTipificacaoCheque As VBLibrary.VB6Label
    Public WithEvents lblDV3 As VBLibrary.VB6Label
    Public WithEvents lblDV2 As VBLibrary.VB6Label
    Public WithEvents lblDV1 As VBLibrary.VB6Label
    Public WithEvents lblChequeNumero As VBLibrary.VB6Label
    Public WithEvents lblConta As VBLibrary.VB6Label
    Public WithEvents lblAgencia As VBLibrary.VB6Label
    Public WithEvents lblBanco As VBLibrary.VB6Label
    Public WithEvents lblComp As VBLibrary.VB6Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmValidaCheque))
        Me.cmdAreaTransferenciaTerceiraBanda = New VBLibrary.VB6CommandButton()
        Me.cmdAreaTransferenciaSegundaBanda = New VBLibrary.VB6CommandButton()
        Me.cmdAreaTransferenciaPrimeiraBanda = New VBLibrary.VB6CommandButton()
        Me.cmdAreaTransferenciaSemCaracteresEspeciais = New VBLibrary.VB6CommandButton()
        Me.cmdAreaTransferenciaComCaracteresEspeciais = New VBLibrary.VB6CommandButton()
        Me.txtBandaMagneticaSemCaracteresEspeciais = New VBLibrary.VB6TextBox()
        Me.cboBanco = New VBLibrary.VB6ComboBox()
        Me.cmdLimparCampos = New VBLibrary.VB6CommandButton()
        Me.cmdExemplo3 = New VBLibrary.VB6CommandButton()
        Me.txtBandaMagneticaComCaracteresEspeciais = New VBLibrary.VB6TextBox()
        Me.cmdExemplo2 = New VBLibrary.VB6CommandButton()
        Me.cmdExemplo1 = New VBLibrary.VB6CommandButton()
        Me.cboTipificacaoCheque = New VBLibrary.VB6ComboBox()
        Me.txtBandaDg3 = New VBLibrary.VB6TextBox()
        Me.txtBandaDg2 = New VBLibrary.VB6TextBox()
        Me.txtBandaDg1 = New VBLibrary.VB6TextBox()
        Me.cmdCalcular = New VBLibrary.VB6CommandButton()
        Me.txtFaixa3 = New VBLibrary.VB6TextBox()
        Me.txtFaixa2 = New VBLibrary.VB6TextBox()
        Me.txtFaixa1 = New VBLibrary.VB6TextBox()
        Me.txtChequeNumero = New VBLibrary.VB6TextBox()
        Me.txtConta = New VBLibrary.VB6TextBox()
        Me.txtAgencia = New VBLibrary.VB6TextBox()
        Me.txtComp = New VBLibrary.VB6TextBox()
        Me.lblBandaMagneticaSemCarcteresEspeciais = New VBLibrary.VB6Label()
        Me.Image1 = New VBLibrary.VB6Image()
        Me.Line6 = New VBLibrary.VB6Line()
        Me.lblBandaMagneticaComCarcteresEspeciais = New VBLibrary.VB6Label()
        Me.Line5 = New VBLibrary.VB6Line()
        Me.Line3 = New VBLibrary.VB6Line()
        Me.Line4 = New VBLibrary.VB6Line()
        Me.Line2 = New VBLibrary.VB6Line()
        Me.Line1 = New VBLibrary.VB6Line()
        Me.lblTerceiraBanda = New VBLibrary.VB6Label()
        Me.lblSegundaBanda = New VBLibrary.VB6Label()
        Me.lblPrimeiraBanda = New VBLibrary.VB6Label()
        Me.lblTipificacaoCheque = New VBLibrary.VB6Label()
        Me.lblDV3 = New VBLibrary.VB6Label()
        Me.lblDV2 = New VBLibrary.VB6Label()
        Me.lblDV1 = New VBLibrary.VB6Label()
        Me.lblChequeNumero = New VBLibrary.VB6Label()
        Me.lblConta = New VBLibrary.VB6Label()
        Me.lblAgencia = New VBLibrary.VB6Label()
        Me.lblBanco = New VBLibrary.VB6Label()
        Me.lblComp = New VBLibrary.VB6Label()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAreaTransferenciaTerceiraBanda
        '
        Me.cmdAreaTransferenciaTerceiraBanda.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAreaTransferenciaTerceiraBanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAreaTransferenciaTerceiraBanda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAreaTransferenciaTerceiraBanda.Location = New System.Drawing.Point(12, 436)
        Me.cmdAreaTransferenciaTerceiraBanda.Name = "cmdAreaTransferenciaTerceiraBanda"
        Me.cmdAreaTransferenciaTerceiraBanda.Size = New System.Drawing.Size(85, 33)
        Me.cmdAreaTransferenciaTerceiraBanda.TabIndex = 37
        Me.cmdAreaTransferenciaTerceiraBanda.Text = "Área Transferência"
        Me.cmdAreaTransferenciaTerceiraBanda.UseVisualStyleBackColor = False
        '
        'cmdAreaTransferenciaSegundaBanda
        '
        Me.cmdAreaTransferenciaSegundaBanda.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAreaTransferenciaSegundaBanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAreaTransferenciaSegundaBanda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAreaTransferenciaSegundaBanda.Location = New System.Drawing.Point(12, 344)
        Me.cmdAreaTransferenciaSegundaBanda.Name = "cmdAreaTransferenciaSegundaBanda"
        Me.cmdAreaTransferenciaSegundaBanda.Size = New System.Drawing.Size(85, 33)
        Me.cmdAreaTransferenciaSegundaBanda.TabIndex = 36
        Me.cmdAreaTransferenciaSegundaBanda.Text = "Área Transferência"
        Me.cmdAreaTransferenciaSegundaBanda.UseVisualStyleBackColor = False
        '
        'cmdAreaTransferenciaPrimeiraBanda
        '
        Me.cmdAreaTransferenciaPrimeiraBanda.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAreaTransferenciaPrimeiraBanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAreaTransferenciaPrimeiraBanda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAreaTransferenciaPrimeiraBanda.Location = New System.Drawing.Point(12, 252)
        Me.cmdAreaTransferenciaPrimeiraBanda.Name = "cmdAreaTransferenciaPrimeiraBanda"
        Me.cmdAreaTransferenciaPrimeiraBanda.Size = New System.Drawing.Size(85, 33)
        Me.cmdAreaTransferenciaPrimeiraBanda.TabIndex = 35
        Me.cmdAreaTransferenciaPrimeiraBanda.Text = "Área Transferência"
        Me.cmdAreaTransferenciaPrimeiraBanda.UseVisualStyleBackColor = False
        '
        'cmdAreaTransferenciaSemCaracteresEspeciais
        '
        Me.cmdAreaTransferenciaSemCaracteresEspeciais.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAreaTransferenciaSemCaracteresEspeciais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAreaTransferenciaSemCaracteresEspeciais.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAreaTransferenciaSemCaracteresEspeciais.Location = New System.Drawing.Point(491, 504)
        Me.cmdAreaTransferenciaSemCaracteresEspeciais.Name = "cmdAreaTransferenciaSemCaracteresEspeciais"
        Me.cmdAreaTransferenciaSemCaracteresEspeciais.Size = New System.Drawing.Size(53, 21)
        Me.cmdAreaTransferenciaSemCaracteresEspeciais.TabIndex = 34
        Me.cmdAreaTransferenciaSemCaracteresEspeciais.Text = "A.Transf."
        Me.cmdAreaTransferenciaSemCaracteresEspeciais.UseVisualStyleBackColor = False
        '
        'cmdAreaTransferenciaComCaracteresEspeciais
        '
        Me.cmdAreaTransferenciaComCaracteresEspeciais.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAreaTransferenciaComCaracteresEspeciais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAreaTransferenciaComCaracteresEspeciais.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAreaTransferenciaComCaracteresEspeciais.Location = New System.Drawing.Point(491, 480)
        Me.cmdAreaTransferenciaComCaracteresEspeciais.Name = "cmdAreaTransferenciaComCaracteresEspeciais"
        Me.cmdAreaTransferenciaComCaracteresEspeciais.Size = New System.Drawing.Size(53, 21)
        Me.cmdAreaTransferenciaComCaracteresEspeciais.TabIndex = 33
        Me.cmdAreaTransferenciaComCaracteresEspeciais.Text = "A.Transf."
        Me.cmdAreaTransferenciaComCaracteresEspeciais.UseVisualStyleBackColor = False
        '
        'txtBandaMagneticaSemCaracteresEspeciais
        '
        Me.txtBandaMagneticaSemCaracteresEspeciais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBandaMagneticaSemCaracteresEspeciais.Location = New System.Drawing.Point(273, 504)
        Me.txtBandaMagneticaSemCaracteresEspeciais.MaxLength = 34
        Me.txtBandaMagneticaSemCaracteresEspeciais.Name = "txtBandaMagneticaSemCaracteresEspeciais"
        Me.txtBandaMagneticaSemCaracteresEspeciais.ReadOnly = True
        Me.txtBandaMagneticaSemCaracteresEspeciais.Size = New System.Drawing.Size(212, 20)
        Me.txtBandaMagneticaSemCaracteresEspeciais.TabIndex = 32
        Me.txtBandaMagneticaSemCaracteresEspeciais.TabStop = False
        Me.txtBandaMagneticaSemCaracteresEspeciais.Text = "001000580012189175704001686452"
        '
        'cboBanco
        '
        Me.cboBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanco.ForeColor = System.Drawing.Color.Green
        Me.cboBanco.Location = New System.Drawing.Point(116, 204)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(201, 21)
        Me.cboBanco.TabIndex = 2
        Me.cboBanco.Text = "237 - BANCO BRADESCO S.A."
        '
        'cmdLimparCampos
        '
        Me.cmdLimparCampos.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLimparCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLimparCampos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLimparCampos.Location = New System.Drawing.Point(371, 540)
        Me.cmdLimparCampos.Name = "cmdLimparCampos"
        Me.cmdLimparCampos.Size = New System.Drawing.Size(85, 21)
        Me.cmdLimparCampos.TabIndex = 29
        Me.cmdLimparCampos.Text = "&Limpar Campos"
        Me.cmdLimparCampos.UseVisualStyleBackColor = False
        '
        'cmdExemplo3
        '
        Me.cmdExemplo3.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExemplo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExemplo3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExemplo3.Location = New System.Drawing.Point(180, 540)
        Me.cmdExemplo3.Name = "cmdExemplo3"
        Me.cmdExemplo3.Size = New System.Drawing.Size(85, 21)
        Me.cmdExemplo3.TabIndex = 28
        Me.cmdExemplo3.Text = "Exemplo &3"
        Me.cmdExemplo3.UseVisualStyleBackColor = False
        '
        'txtBandaMagneticaComCaracteresEspeciais
        '
        Me.txtBandaMagneticaComCaracteresEspeciais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBandaMagneticaComCaracteresEspeciais.Location = New System.Drawing.Point(273, 480)
        Me.txtBandaMagneticaComCaracteresEspeciais.MaxLength = 34
        Me.txtBandaMagneticaComCaracteresEspeciais.Name = "txtBandaMagneticaComCaracteresEspeciais"
        Me.txtBandaMagneticaComCaracteresEspeciais.ReadOnly = True
        Me.txtBandaMagneticaComCaracteresEspeciais.Size = New System.Drawing.Size(212, 20)
        Me.txtBandaMagneticaComCaracteresEspeciais.TabIndex = 25
        Me.txtBandaMagneticaComCaracteresEspeciais.TabStop = False
        Me.txtBandaMagneticaComCaracteresEspeciais.Text = "<00100058<0012189175>704001686452>"
        '
        'cmdExemplo2
        '
        Me.cmdExemplo2.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExemplo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExemplo2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExemplo2.Location = New System.Drawing.Point(92, 540)
        Me.cmdExemplo2.Name = "cmdExemplo2"
        Me.cmdExemplo2.Size = New System.Drawing.Size(85, 21)
        Me.cmdExemplo2.TabIndex = 27
        Me.cmdExemplo2.Text = "Exemplo &2"
        Me.cmdExemplo2.UseVisualStyleBackColor = False
        '
        'cmdExemplo1
        '
        Me.cmdExemplo1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExemplo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExemplo1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExemplo1.Location = New System.Drawing.Point(4, 540)
        Me.cmdExemplo1.Name = "cmdExemplo1"
        Me.cmdExemplo1.Size = New System.Drawing.Size(85, 21)
        Me.cmdExemplo1.TabIndex = 26
        Me.cmdExemplo1.Text = "Exemplo &1"
        Me.cmdExemplo1.UseVisualStyleBackColor = False
        '
        'cboTipificacaoCheque
        '
        Me.cboTipificacaoCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipificacaoCheque.ForeColor = System.Drawing.Color.Green
        Me.cboTipificacaoCheque.ItemDataValues = "Comum\ \(5\)\ \r5\rBancário\ \(6\)\r6\rSalário\ \(7\)\r7\rAdministrativo\ \(8\)\r" &
    "8\rCPMF\ \(9\)\r9"
        Me.cboTipificacaoCheque.Location = New System.Drawing.Point(116, 352)
        Me.cboTipificacaoCheque.Name = "cboTipificacaoCheque"
        Me.cboTipificacaoCheque.Size = New System.Drawing.Size(109, 21)
        Me.cboTipificacaoCheque.TabIndex = 14
        Me.cboTipificacaoCheque.Text = "5 - Comum"
        '
        'txtBandaDg3
        '
        Me.txtBandaDg3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBandaDg3.ForeColor = System.Drawing.Color.Red
        Me.txtBandaDg3.Location = New System.Drawing.Point(116, 444)
        Me.txtBandaDg3.MaxLength = 1
        Me.txtBandaDg3.Name = "txtBandaDg3"
        Me.txtBandaDg3.ReadOnly = True
        Me.txtBandaDg3.Size = New System.Drawing.Size(17, 20)
        Me.txtBandaDg3.TabIndex = 22
        Me.txtBandaDg3.TabStop = False
        Me.txtBandaDg3.Text = "9"
        '
        'txtBandaDg2
        '
        Me.txtBandaDg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBandaDg2.ForeColor = System.Drawing.Color.Red
        Me.txtBandaDg2.Location = New System.Drawing.Point(116, 260)
        Me.txtBandaDg2.MaxLength = 1
        Me.txtBandaDg2.Name = "txtBandaDg2"
        Me.txtBandaDg2.ReadOnly = True
        Me.txtBandaDg2.Size = New System.Drawing.Size(17, 20)
        Me.txtBandaDg2.TabIndex = 6
        Me.txtBandaDg2.TabStop = False
        Me.txtBandaDg2.Text = "2"
        '
        'txtBandaDg1
        '
        Me.txtBandaDg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBandaDg1.ForeColor = System.Drawing.Color.Red
        Me.txtBandaDg1.Location = New System.Drawing.Point(116, 388)
        Me.txtBandaDg1.MaxLength = 1
        Me.txtBandaDg1.Name = "txtBandaDg1"
        Me.txtBandaDg1.ReadOnly = True
        Me.txtBandaDg1.Size = New System.Drawing.Size(17, 20)
        Me.txtBandaDg1.TabIndex = 18
        Me.txtBandaDg1.TabStop = False
        Me.txtBandaDg1.Text = "7"
        '
        'cmdCalcular
        '
        Me.cmdCalcular.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalcular.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalcular.Location = New System.Drawing.Point(459, 540)
        Me.cmdCalcular.Name = "cmdCalcular"
        Me.cmdCalcular.Size = New System.Drawing.Size(85, 21)
        Me.cmdCalcular.TabIndex = 30
        Me.cmdCalcular.Text = "&Calcular"
        Me.cmdCalcular.UseVisualStyleBackColor = False
        '
        'txtFaixa3
        '
        Me.txtFaixa3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaixa3.Location = New System.Drawing.Point(4, 408)
        Me.txtFaixa3.MaxLength = 12
        Me.txtFaixa3.Name = "txtFaixa3"
        Me.txtFaixa3.ReadOnly = True
        Me.txtFaixa3.Size = New System.Drawing.Size(89, 20)
        Me.txtFaixa3.TabIndex = 17
        Me.txtFaixa3.TabStop = False
        Me.txtFaixa3.Text = "200000104464"
        '
        'txtFaixa2
        '
        Me.txtFaixa2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaixa2.Location = New System.Drawing.Point(4, 316)
        Me.txtFaixa2.MaxLength = 10
        Me.txtFaixa2.Name = "txtFaixa2"
        Me.txtFaixa2.ReadOnly = True
        Me.txtFaixa2.Size = New System.Drawing.Size(69, 20)
        Me.txtFaixa2.TabIndex = 9
        Me.txtFaixa2.TabStop = False
        Me.txtFaixa2.Text = "0180032515"
        '
        'txtFaixa1
        '
        Me.txtFaixa1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaixa1.Location = New System.Drawing.Point(4, 224)
        Me.txtFaixa1.MaxLength = 8
        Me.txtFaixa1.Name = "txtFaixa1"
        Me.txtFaixa1.ReadOnly = True
        Me.txtFaixa1.Size = New System.Drawing.Size(57, 20)
        Me.txtFaixa1.TabIndex = 1
        Me.txtFaixa1.TabStop = False
        Me.txtFaixa1.Text = "00125402"
        '
        'txtChequeNumero
        '
        Me.txtChequeNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNumero.Location = New System.Drawing.Point(116, 324)
        Me.txtChequeNumero.MaxLength = 6
        Me.txtChequeNumero.Name = "txtChequeNumero"
        Me.txtChequeNumero.Size = New System.Drawing.Size(45, 20)
        Me.txtChequeNumero.TabIndex = 12
        Me.txtChequeNumero.Text = "003489"
        Me.ToolTip1.SetToolTip(Me.txtChequeNumero, "Número do Cheque")
        '
        'txtConta
        '
        Me.txtConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConta.Location = New System.Drawing.Point(116, 416)
        Me.txtConta.MaxLength = 10
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(73, 20)
        Me.txtConta.TabIndex = 20
        Me.txtConta.Text = "7750436240"
        Me.ToolTip1.SetToolTip(Me.txtConta, "Número da Conta Corrente")
        '
        'txtAgencia
        '
        Me.txtAgencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgencia.Location = New System.Drawing.Point(116, 232)
        Me.txtAgencia.MaxLength = 4
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Size = New System.Drawing.Size(33, 20)
        Me.txtAgencia.TabIndex = 4
        Me.txtAgencia.Text = "3184"
        Me.ToolTip1.SetToolTip(Me.txtAgencia, "Código da Agência")
        '
        'txtComp
        '
        Me.txtComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComp.Location = New System.Drawing.Point(116, 296)
        Me.txtComp.MaxLength = 3
        Me.txtComp.Name = "txtComp"
        Me.txtComp.Size = New System.Drawing.Size(29, 20)
        Me.txtComp.TabIndex = 10
        Me.txtComp.Text = "001"
        Me.ToolTip1.SetToolTip(Me.txtComp, "Código da Câmara de Compensação")
        '
        'lblBandaMagneticaSemCarcteresEspeciais
        '
        Me.lblBandaMagneticaSemCarcteresEspeciais.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBandaMagneticaSemCarcteresEspeciais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBandaMagneticaSemCarcteresEspeciais.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblBandaMagneticaSemCarcteresEspeciais.Location = New System.Drawing.Point(4, 504)
        Me.lblBandaMagneticaSemCarcteresEspeciais.Name = "lblBandaMagneticaSemCarcteresEspeciais"
        Me.lblBandaMagneticaSemCarcteresEspeciais.Size = New System.Drawing.Size(263, 17)
        Me.lblBandaMagneticaSemCarcteresEspeciais.TabIndex = 31
        Me.lblBandaMagneticaSemCarcteresEspeciais.Text = "Banda Magnética (30 sem os 4 caracteres especiais)"
        '
        'Image1
        '
        Me.Image1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(44, 9)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(467, 189)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Image1.TabIndex = 38
        Me.Image1.TabStop = False
        '
        'Line6
        '
        Me.Line6.Container = Me
        Me.Line6.Name = "Line6"
        Me.Line6.Name6 = "Line6"
        Me.Line6.ParentForm = Me
        Me.Line6.X1 = 60.0!
        Me.Line6.X2 = 7860.0!
        Me.Line6.Y1 = 7980.0!
        Me.Line6.Y2 = 7980.0!
        '
        'lblBandaMagneticaComCarcteresEspeciais
        '
        Me.lblBandaMagneticaComCarcteresEspeciais.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBandaMagneticaComCarcteresEspeciais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBandaMagneticaComCarcteresEspeciais.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblBandaMagneticaComCarcteresEspeciais.Location = New System.Drawing.Point(4, 484)
        Me.lblBandaMagneticaComCarcteresEspeciais.Name = "lblBandaMagneticaComCarcteresEspeciais"
        Me.lblBandaMagneticaComCarcteresEspeciais.Size = New System.Drawing.Size(263, 17)
        Me.lblBandaMagneticaComCarcteresEspeciais.TabIndex = 24
        Me.lblBandaMagneticaComCarcteresEspeciais.Text = "Banda Magnética (34 com os 4 caracteres especiais)"
        '
        'Line5
        '
        Me.Line5.Container = Me
        Me.Line5.Name = "Line5"
        Me.Line5.Name6 = "Line5"
        Me.Line5.ParentForm = Me
        Me.Line5.X1 = 1620.0!
        Me.Line5.X2 = 1620.0!
        Me.Line5.Y1 = 7080.0!
        Me.Line5.Y2 = 3060.0!
        '
        'Line3
        '
        Me.Line3.Container = Me
        Me.Line3.Name = "Line3"
        Me.Line3.Name6 = "Line3"
        Me.Line3.ParentForm = Me
        Me.Line3.X1 = 60.0!
        Me.Line3.X2 = 7860.0!
        Me.Line3.Y1 = 7080.0!
        Me.Line3.Y2 = 7080.0!
        '
        'Line4
        '
        Me.Line4.Container = Me
        Me.Line4.Name = "Line4"
        Me.Line4.Name6 = "Line4"
        Me.Line4.ParentForm = Me
        Me.Line4.X1 = 4860.0!
        Me.Line4.X2 = 4860.0!
        Me.Line4.Y1 = 7080.0!
        Me.Line4.Y2 = 3060.0!
        '
        'Line2
        '
        Me.Line2.Container = Me
        Me.Line2.Name = "Line2"
        Me.Line2.Name6 = "Line2"
        Me.Line2.ParentForm = Me
        Me.Line2.X1 = 180.0!
        Me.Line2.X2 = 7860.0!
        Me.Line2.Y1 = 5700.0!
        Me.Line2.Y2 = 5700.0!
        '
        'Line1
        '
        Me.Line1.Container = Me
        Me.Line1.Name = "Line1"
        Me.Line1.Name6 = "Line1"
        Me.Line1.ParentForm = Me
        Me.Line1.X1 = 180.0!
        Me.Line1.X2 = 7860.0!
        Me.Line1.Y1 = 4320.0!
        Me.Line1.Y2 = 4320.0!
        '
        'lblTerceiraBanda
        '
        Me.lblTerceiraBanda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTerceiraBanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerceiraBanda.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblTerceiraBanda.Location = New System.Drawing.Point(4, 388)
        Me.lblTerceiraBanda.Name = "lblTerceiraBanda"
        Me.lblTerceiraBanda.Size = New System.Drawing.Size(101, 17)
        Me.lblTerceiraBanda.TabIndex = 16
        Me.lblTerceiraBanda.Text = "Terceira Banda (12)"
        '
        'lblSegundaBanda
        '
        Me.lblSegundaBanda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSegundaBanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundaBanda.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblSegundaBanda.Location = New System.Drawing.Point(4, 296)
        Me.lblSegundaBanda.Name = "lblSegundaBanda"
        Me.lblSegundaBanda.Size = New System.Drawing.Size(101, 17)
        Me.lblSegundaBanda.TabIndex = 8
        Me.lblSegundaBanda.Text = "Segunda Banda (10)"
        '
        'lblPrimeiraBanda
        '
        Me.lblPrimeiraBanda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPrimeiraBanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimeiraBanda.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblPrimeiraBanda.Location = New System.Drawing.Point(4, 204)
        Me.lblPrimeiraBanda.Name = "lblPrimeiraBanda"
        Me.lblPrimeiraBanda.Size = New System.Drawing.Size(101, 17)
        Me.lblPrimeiraBanda.TabIndex = 0
        Me.lblPrimeiraBanda.Text = "Primeira Banda (8)"
        '
        'lblTipificacaoCheque
        '
        Me.lblTipificacaoCheque.BackColor = System.Drawing.SystemColors.Control
        Me.lblTipificacaoCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipificacaoCheque.ForeColor = System.Drawing.Color.Green
        Me.lblTipificacaoCheque.Location = New System.Drawing.Point(332, 356)
        Me.lblTipificacaoCheque.Name = "lblTipificacaoCheque"
        Me.lblTipificacaoCheque.Size = New System.Drawing.Size(212, 17)
        Me.lblTipificacaoCheque.TabIndex = 15
        Me.lblTipificacaoCheque.Text = "Tipificação do Cheque (1)"
        Me.ToolTip1.SetToolTip(Me.lblTipificacaoCheque, "Tipificação do Cheque (5–Comum 6–Bancário 7–Salário 8–Administrativo 9–CPMF)")
        '
        'lblDV3
        '
        Me.lblDV3.BackColor = System.Drawing.SystemColors.Control
        Me.lblDV3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDV3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDV3.Location = New System.Drawing.Point(332, 448)
        Me.lblDV3.Name = "lblDV3"
        Me.lblDV3.Size = New System.Drawing.Size(212, 17)
        Me.lblDV3.TabIndex = 23
        Me.lblDV3.Text = "Dígito verificador da Terceira Banda (1)"
        '
        'lblDV2
        '
        Me.lblDV2.BackColor = System.Drawing.SystemColors.Control
        Me.lblDV2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDV2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDV2.Location = New System.Drawing.Point(332, 264)
        Me.lblDV2.Name = "lblDV2"
        Me.lblDV2.Size = New System.Drawing.Size(212, 17)
        Me.lblDV2.TabIndex = 7
        Me.lblDV2.Text = "Dígito Verificador da Segunda Banda (1)"
        '
        'lblDV1
        '
        Me.lblDV1.BackColor = System.Drawing.SystemColors.Control
        Me.lblDV1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDV1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDV1.Location = New System.Drawing.Point(332, 392)
        Me.lblDV1.Name = "lblDV1"
        Me.lblDV1.Size = New System.Drawing.Size(197, 17)
        Me.lblDV1.TabIndex = 19
        Me.lblDV1.Text = "Dígito verificador da Primeira Banda (1)"
        '
        'lblChequeNumero
        '
        Me.lblChequeNumero.BackColor = System.Drawing.SystemColors.Control
        Me.lblChequeNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequeNumero.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChequeNumero.Location = New System.Drawing.Point(332, 328)
        Me.lblChequeNumero.Name = "lblChequeNumero"
        Me.lblChequeNumero.Size = New System.Drawing.Size(212, 17)
        Me.lblChequeNumero.TabIndex = 13
        Me.lblChequeNumero.Text = "Número do Cheque (6)"
        Me.ToolTip1.SetToolTip(Me.lblChequeNumero, "Número do Cheque")
        '
        'lblConta
        '
        Me.lblConta.BackColor = System.Drawing.SystemColors.Control
        Me.lblConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblConta.Location = New System.Drawing.Point(332, 420)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(197, 17)
        Me.lblConta.TabIndex = 21
        Me.lblConta.Text = "Conta (10)"
        Me.ToolTip1.SetToolTip(Me.lblConta, "Número da Conta Corrente")
        '
        'lblAgencia
        '
        Me.lblAgencia.BackColor = System.Drawing.SystemColors.Control
        Me.lblAgencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgencia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAgencia.Location = New System.Drawing.Point(332, 236)
        Me.lblAgencia.Name = "lblAgencia"
        Me.lblAgencia.Size = New System.Drawing.Size(212, 17)
        Me.lblAgencia.TabIndex = 5
        Me.lblAgencia.Text = "Código da Agência (4)"
        Me.ToolTip1.SetToolTip(Me.lblAgencia, "Código da Agência")
        '
        'lblBanco
        '
        Me.lblBanco.BackColor = System.Drawing.SystemColors.Control
        Me.lblBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanco.ForeColor = System.Drawing.Color.Green
        Me.lblBanco.Location = New System.Drawing.Point(332, 208)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(212, 17)
        Me.lblBanco.TabIndex = 3
        Me.lblBanco.Text = "Código do Banco (3)"
        Me.ToolTip1.SetToolTip(Me.lblBanco, "Código do Banco")
        '
        'lblComp
        '
        Me.lblComp.BackColor = System.Drawing.SystemColors.Control
        Me.lblComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblComp.Location = New System.Drawing.Point(332, 300)
        Me.lblComp.Name = "lblComp"
        Me.lblComp.Size = New System.Drawing.Size(212, 17)
        Me.lblComp.TabIndex = 11
        Me.lblComp.Text = "Código da Câmara de Compensação (3)"
        Me.ToolTip1.SetToolTip(Me.lblComp, "Código da Câmara de Compensação")
        '
        'frmValidaCheque
        '
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BorderStyle = VBLibrary.VBRUN.FormBorderStyleConstants.vbFixedSingle
        Me.ClientSize = New System.Drawing.Size(552, 567)
        Me.Controls.Add(Me.cmdAreaTransferenciaTerceiraBanda)
        Me.Controls.Add(Me.cmdAreaTransferenciaSegundaBanda)
        Me.Controls.Add(Me.cmdAreaTransferenciaPrimeiraBanda)
        Me.Controls.Add(Me.cmdAreaTransferenciaSemCaracteresEspeciais)
        Me.Controls.Add(Me.cmdAreaTransferenciaComCaracteresEspeciais)
        Me.Controls.Add(Me.txtBandaMagneticaSemCaracteresEspeciais)
        Me.Controls.Add(Me.cboBanco)
        Me.Controls.Add(Me.cmdLimparCampos)
        Me.Controls.Add(Me.cmdExemplo3)
        Me.Controls.Add(Me.txtBandaMagneticaComCaracteresEspeciais)
        Me.Controls.Add(Me.cmdExemplo2)
        Me.Controls.Add(Me.cmdExemplo1)
        Me.Controls.Add(Me.cboTipificacaoCheque)
        Me.Controls.Add(Me.txtBandaDg3)
        Me.Controls.Add(Me.txtBandaDg2)
        Me.Controls.Add(Me.txtBandaDg1)
        Me.Controls.Add(Me.cmdCalcular)
        Me.Controls.Add(Me.txtFaixa3)
        Me.Controls.Add(Me.txtFaixa2)
        Me.Controls.Add(Me.txtFaixa1)
        Me.Controls.Add(Me.txtChequeNumero)
        Me.Controls.Add(Me.txtConta)
        Me.Controls.Add(Me.txtAgencia)
        Me.Controls.Add(Me.txtComp)
        Me.Controls.Add(Me.lblBandaMagneticaSemCarcteresEspeciais)
        Me.Controls.Add(Me.Image1)
        Me.Controls.Add(Me.lblBandaMagneticaComCarcteresEspeciais)
        Me.Controls.Add(Me.lblTerceiraBanda)
        Me.Controls.Add(Me.lblSegundaBanda)
        Me.Controls.Add(Me.lblPrimeiraBanda)
        Me.Controls.Add(Me.lblTipificacaoCheque)
        Me.Controls.Add(Me.lblDV3)
        Me.Controls.Add(Me.lblDV2)
        Me.Controls.Add(Me.lblDV1)
        Me.Controls.Add(Me.lblChequeNumero)
        Me.Controls.Add(Me.lblConta)
        Me.Controls.Add(Me.lblAgencia)
        Me.Controls.Add(Me.lblBanco)
        Me.Controls.Add(Me.lblComp)
        Me.DrawMode = VBLibrary.VBRUN.DrawModeConstants.vbCopyPen
        Me.DrawStyle = VBLibrary.VBRUN.DrawStyleConstants.vbSolid
        Me.FillStyle = VBLibrary.VBRUN.FillStyleConstants.vbFSTransparent
        Me.Location = New System.Drawing.Point(74, 117)
        Me.MaxButton = False
        Me.MinButton = False
        Me.MinimizeBox = False
        Me.MousePointer = VBLibrary.VBRUN.MousePointerConstants.vbDefault
        Me.Name = "frmValidaCheque"
        Me.OLEDropMode = VBLibrary.VBRUN.OLEDropConstants.vbOLEDropNone
        Me.ScaleMode = VBLibrary.VBRUN.ScaleModeConstants.vbTwips
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Valida Cheque - CMC7 - (Caracteres Magnéticos Codificados em 7 Barras)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


End Class
