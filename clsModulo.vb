'--------------------------------------------------------------------------------
' Código gerado pela conversão de VB6 para VB.NET
'--------------------------------------------------------------------------------

Option Strict Off ' Código convertido do VB6 possui Option Strict Off por padrão

Imports VB = Microsoft.VisualBasic

Friend Class clsModulo

    ' CONVERSAO_INFO (#0511): O membro 'Contador' é referenciado apenas por membros que não são usados nessa aplicação.
    Private Contador As Short 'Não pode ser tipo BYTE!

    ' CONVERSAO_INFO (#0501): O membro 'Modulo10' não é usada em nenhum lugar nessa aplicação.
    ' CONVERSAO_INFO (#0561): O símbolo 'Modulo10' foi definido sem o uso explícito da cláusula "As".
    Public Function Modulo10(ByRef Calculo As Object) As Object
        Dim i As Short
        Dim nDigito As Short = 0
        Dim nSoma As Short = 0
        Dim nSoma2 As Short

        ' CONVERSAO_AVISO (#0364): Não é possível atribuir ao membro padrão de 'Calculo'. Considere utilizar a rotina SetDefaultMember6.
        Calculo = Trim(Calculo)

        ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'Calculo'. Considere utilizar a rotina GetDefaultMember6.
        If Len6(Calculo) <> 0 Then

            ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'Calculo'. Considere utilizar a rotina GetDefaultMember6.
            For i = 0 To Len6(Calculo) - 1
                ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'Calculo'. Considere utilizar a rotina GetDefaultMember6.
                nSoma2 = (Val(Mid(Calculo, Len6(Calculo) - i, 1)) * 2)
                If Len6(nSoma2) = 2 Then
                    nSoma2 = Val(Mid(nSoma2, 1, 1)) + Val(Mid(nSoma2, 2, 1))
                End If

                nSoma += nSoma2

                i += 1
                ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'Calculo'. Considere utilizar a rotina GetDefaultMember6.
                If i = Len6(Calculo) Then
                    Exit For
                End If

                ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'Calculo'. Considere utilizar a rotina GetDefaultMember6.
                nSoma += (Val(Mid(Calculo, Len6(Calculo) - i, 1)))
            Next

            nDigito = nSoma Mod 10
            If nDigito <> 0 Then
                nDigito = 10 - nDigito
            End If

        End If

        Return nDigito

    End Function

    ' CONVERSAO_INFO (#0501): O membro 'Modulo11' não é usada em nenhum lugar nessa aplicação.
    ' CONVERSAO_INFO (#0561): O símbolo 'Modulo11' foi definido sem o uso explícito da cláusula "As".
    Public Function Modulo11(ByRef Calculo As Object) As Object
        Dim i As Short
        Dim a As Short
        Dim nDigito As Short = 0
        Dim nSoma As Short = 0
        Dim nSoma2 As Short

        ' CONVERSAO_AVISO (#0364): Não é possível atribuir ao membro padrão de 'Calculo'. Considere utilizar a rotina SetDefaultMember6.
        Calculo = Trim(Calculo)

        ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'Calculo'. Considere utilizar a rotina GetDefaultMember6.
        If Len6(Calculo) <> 0 Then

            ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'Calculo'. Considere utilizar a rotina GetDefaultMember6.
            While i <> Len6(Calculo)

                For a = 2 To 9

                    ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'Calculo'. Considere utilizar a rotina GetDefaultMember6.
                    nSoma2 = (Val(Mid(Calculo, Len6(Calculo) - i, 1)) * a)

                    'If Len(nSoma2) = 2 Then
                    '    nSoma2 = Val(Mid(nSoma2, 1, 1)) + Val(Mid(nSoma2, 2, 1))
                    'End If

                    nSoma += nSoma2

                    i += 1

                    ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'Calculo'. Considere utilizar a rotina GetDefaultMember6.
                    If i = Len6(Calculo) Then Exit For

                Next

            End While

            nDigito = nSoma Mod 11
            If nDigito <> 0 Then

                nDigito = 11 - nDigito
                'If nDigito = 10 Then
                '     nDigito = 0
                'End If
                If nDigito = 0 Or nDigito = 1 Or nDigito > 9 Then
                    nDigito = 1
                End If

                'mf em 27022002 10:50hs
            Else
                nDigito = 1

            End If

        End If

        Return nDigito

    End Function

    ' CONVERSAO_INFO (#0501): O membro 'Modulo11Arr' não é usada em nenhum lugar nessa aplicação.
    ' CONVERSAO_INFO (#0561): O símbolo 'Modulo11Arr' foi definido sem o uso explícito da cláusula "As".
    Public Function Modulo11Arr(ByRef Calculo As Object) As Object
        Dim i As Short
        Dim a As Short
        Dim nDigito As Short = 0
        Dim nSoma As Short = 0
        Dim nSoma2 As Short

        ' CONVERSAO_AVISO (#0364): Não é possível atribuir ao membro padrão de 'Calculo'. Considere utilizar a rotina SetDefaultMember6.
        Calculo = Trim(Calculo)

        ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'Calculo'. Considere utilizar a rotina GetDefaultMember6.
        If Len6(Calculo) <> 0 Then

            ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'Calculo'. Considere utilizar a rotina GetDefaultMember6.
            While i <> Len6(Calculo)

                For a = 2 To 9

                    ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'Calculo'. Considere utilizar a rotina GetDefaultMember6.
                    nSoma2 = (Val(Mid(Calculo, Len6(Calculo) - i, 1)) * a)

                    ' If Len(nSoma2) = 2 Then
                    '     nSoma2 = Val(Mid(nSoma2, 1, 1)) + Val(Mid(nSoma2, 2, 1))
                    ' End If

                    nSoma += nSoma2

                    i += 1

                    ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'Calculo'. Considere utilizar a rotina GetDefaultMember6.
                    If i = Len6(Calculo) Then Exit For

                Next

            End While

            ''  Conforme consta no manual Febraban versão 4  arrecadação datado em 28/05/2004
            ''  o dv geral deverá seguir a seguinte regra

            ''A soma dos produtos dessa multiplicação é dividida por 11 e
            ''obtém-se o resto da divisão, este resto deve ser subtraído de 11, o produto da subtração é o DAC - 'Dígito'.
            ''Observação: Quando o resto da divisão for igual a 0 ou 1, atribuí-se ao DV o digito "0",
            ''e quando for 10, atribuí-se ao DV o digito "1".

            nDigito = nSoma Mod 11
            nDigito = 11 - nDigito

            If nDigito > 9 Then
                nDigito = 0
            End If

            If nDigito = 10 Then
                nDigito = 1
            End If

        End If

        Return nDigito

    End Function

    ' CONVERSAO_INFO (#0501): O membro 'MOD10' não é usada em nenhum lugar nessa aplicação.
    ' CONVERSAO_INFO (#0551): O parâmetro 'strDACC' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    Public Function MOD10(ByRef strDACC As String) As String
        Dim Marcador As Boolean = True
        Dim intDACC As Short = 0
        Dim intDACCTotal As Short = 0
        Dim intDACCResto As Short

        For Contador = Len6(strDACC) To 1 Step -1
            intDACC = Val(Mid(strDACC, Contador, 1))

            If Marcador = True Then
                Marcador = False
                intDACC *= 2

                If intDACC > 9 Then
                    intDACC = Val(Mid(Trim(Str6(intDACC)), 1, 1)) + Val(Mid(Trim(Str6(intDACC)), 2, 1))
                End If

            Else
                Marcador = True
            End If

            intDACCTotal += intDACC
        Next

        intDACCResto = Int(intDACCTotal Mod 10)

        If intDACCResto = 0 Then
            Return 0
        Else
            Return 10 - intDACCResto
        End If

    End Function

    ' CONVERSAO_INFO (#0501): O membro 'MOD11' não é usada em nenhum lugar nessa aplicação.
    ' CONVERSAO_INFO (#0551): O parâmetro 'strDACB' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    Public Function MOD11(ByRef strDACB As String) As String
        Dim intDACB As Short = 0
        Dim intDACBTotal As Short = 0
        Dim intDACBResto As Short
        Dim Peso As Byte = 2

        For Contador = Len6(strDACB) To 1 Step -1
            intDACB = Val(Mid(strDACB, Contador, 1))
            intDACB *= Peso
            intDACBTotal += intDACB
            Peso += 1

            If Peso > 9 Then
                Peso = 2
            End If

        Next

        intDACBResto = Int(intDACBTotal Mod 11)

        If intDACBResto = 0 Or intDACBResto = 1 Or intDACBResto = 10 Or intDACBResto = 11 Then
            Return 1
        Else
            Return 11 - intDACBResto
        End If

    End Function

    ' CONVERSAO_INFO (#0501): O membro 'DAC' não é usada em nenhum lugar nessa aplicação.
    ' CONVERSAO_INFO (#0551): O parâmetro 'strNumeroDaAgenciaCedente' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    ' CONVERSAO_INFO (#0551): O parâmetro 'strNumeroDaContaCorrente' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    ' CONVERSAO_INFO (#0551): O parâmetro 'strCarteira' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    ' CONVERSAO_INFO (#0551): O parâmetro 'strNossoNumero' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    Public Function DAC(ByRef strNumeroDaAgenciaCedente As String, ByRef strNumeroDaContaCorrente As String, ByRef strCarteira As String, ByRef strNossoNumero As String) As String
        Dim Marcador As Boolean = True
        Dim strDACD As String = ""
        Dim intDACD As Short = 0
        Dim intDACDTotal As Short = 0
        Dim intDACDResto As Short

        If strCarteira = "126" Or strCarteira = "131" Or strCarteira = "146" Or strCarteira = "150" Or strCarteira = "168" Then
            strDACD = strCarteira & strNossoNumero
        Else
            strDACD = strNumeroDaAgenciaCedente & strNumeroDaContaCorrente & strCarteira & strNossoNumero
        End If

        For Contador = Len6(strDACD) To 1 Step -1
            intDACD = Val(Mid(strDACD, Contador, 1))

            If Marcador = True Then
                Marcador = False
                intDACD *= 2

                If intDACD > 9 Then
                    intDACD = Val(Mid(Trim(Str6(intDACD)), 1, 1)) + Val(Mid(Trim(Str6(intDACD)), 2, 1))
                End If

            Else
                Marcador = True
            End If

            intDACDTotal += intDACD
        Next

        intDACDResto = Int(intDACDTotal Mod 10)

        If intDACDResto = 0 Then
            Return 0
        Else
            Return 10 - intDACDResto
        End If

    End Function

    ' CONVERSAO_INFO (#0561): O símbolo 'DV_MOD10' foi definido sem o uso explícito da cláusula "As".
    ' CONVERSAO_INFO (#0551): O parâmetro 'Numero' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    Public Function DV_MOD10(ByRef Numero As String) As Object
        Dim tamanho As Short = Len6(Numero)
        Dim Numerox As String = Numero
        Dim soma As Integer = 0
        Dim Somax As Integer
        Dim Peso As String = ""
        Dim i As Short

        If tamanho <> 0 Then
            Peso = VB.Right("1212121212", tamanho)

            For i = tamanho To 1 Step -1
                Somax = Val(Mid(Numerox, i, 1)) * Val(Mid(Peso, i, 1))
                If Somax > 9 Then
                    Somax = Val(Mid(Somax, 1, 1)) + Val(Mid(Somax, 2, 1))
                End If
                soma += Somax
                If i > 1 Then
                    Numerox = VB.Left(Numerox, (i - 1))
                End If
            Next

            soma = 9 * soma
            Return soma Mod (10)
        End If

    End Function

    ' CONVERSAO_INFO (#0561): O símbolo 'Dig_Base10' foi definido sem o uso explícito da cláusula "As".
    ' CONVERSAO_INFO (#0561): O símbolo 'xPCODIGO' foi definido sem o uso explícito da cláusula "As".
    ' CONVERSAO_INFO (#0551): O parâmetro 'xPCODIGO' não foi modificado ou passado para um método que o modifique. Considere remover o ByRef.
    Public Function Dig_Base10(ByRef xPCODIGO As Object) As Object

        ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'xPCODIGO'. Considere utilizar a rotina GetDefaultMember6.
        Dim cMaxDig As String = Len6(xPCODIGO)
        Dim flag As Boolean = True
        Dim Tx As Short
        Dim TVlr As String = 0
        Dim TDig As String = ""

        For Tx = cMaxDig To 1 Step -1
            If flag Then
                ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'xPCODIGO'. Considere utilizar a rotina GetDefaultMember6.
                TDig = (Val(Mid(xPCODIGO, Tx, 1)) * 2)
                flag = False
            Else
                ' CONVERSAO_AVISO (#0354): Não é possível ler o membro padrão de 'xPCODIGO'. Considere utilizar a rotina GetDefaultMember6.
                TDig = Val(Mid(xPCODIGO, Tx, 1))
                flag = True
            End If

            If TDig > 9 Then
                TDig = 1 + (TDig - 10)
                TVlr = Val(TVlr) + Val(TDig)
            Else
                TVlr = Val(TVlr) + Val(TDig)
            End If
        Next

        TDig = 10 * ((TVlr / 10) - Int(TVlr / 10))

        If TDig > 0 Then
            TDig = 10 - TDig
        End If

        Return TDig

    End Function

End Class
