
Module AssemblyForm


    'Public Function GenerateFrom(ByVal AssemblyName As String, ByVal FormName As String, ID As VariantType) As Form
    '    Dim frm As Form
    '    Dim FullFormName As String = ""

    '    If AssemblyName.Trim = "" Then
    '        FullFormName = System.Reflection.Assembly.GetEntryAssembly.GetName.Name & "." & FormName
    '        frm = System.Activator.CreateInstance(System.Type.GetType(FullFormName), ID)
    '    Else
    '        Dim a As System.Reflection.Assembly
    '        a = System.Reflection.Assembly.Load(AssemblyName)
    '        FullFormName = AssemblyName & "." & FormName
    '        frm = System.Activator.CreateInstance(a.GetType(FullFormName), ID)

    '    End If

    '    Return frm

    'End Function

    Public Function GenerateFrom(ByVal AssemblyName As String, ByVal FormName As String, strParam As String) As Form
        Dim frm As Form
        Dim FullFormName As String = ""

        If strParam.Trim = "" Then
            If AssemblyName.Trim = "" Then
                FullFormName = System.Reflection.Assembly.GetEntryAssembly.GetName.Name & "." & FormName
                frm = System.Activator.CreateInstance(System.Type.GetType(FullFormName))
            Else
                Dim a As System.Reflection.Assembly
                a = System.Reflection.Assembly.Load(AssemblyName)
                FullFormName = AssemblyName & "." & FormName
                frm = System.Activator.CreateInstance(a.GetType(FullFormName))

            End If
        Else
            Dim dt As New DataTable
            Dim dr0 As DataRow = dt.NewRow
            dt.Rows.Add(dr0)

            Dim stringseparators() As Char = {";"}
            Dim prm() As String
            prm = strParam.Split(stringseparators)

            Dim i As Integer = 0
            Dim clmnName As String = ""

            For Each c In prm
                Dim t() As String
                t = c.Split(":")
                clmnName = "C" + i.ToString
                dt.Columns.Add(clmnName, Type.GetType(t(1)))
                dt.Rows(0)(clmnName) = t(0)
                i = i + 1
            Next

            Dim FormParameters As DataRow = dt.Rows(0)

            If AssemblyName.Trim = "" Then
                FullFormName = System.Reflection.Assembly.GetEntryAssembly.GetName.Name & "." & FormName
                frm = System.Activator.CreateInstance(System.Type.GetType(FullFormName), FormParameters.ItemArray)
            Else
                Dim a As System.Reflection.Assembly
                a = System.Reflection.Assembly.Load(AssemblyName)
                FullFormName = AssemblyName & "." & FormName
                frm = System.Activator.CreateInstance(a.GetType(FullFormName), FormParameters.ItemArray)

            End If
        End If



        Return frm

    End Function

    Public Function GenerateFrom(ByVal AssemblyName As String, ByVal FormName As String) As Form
        'Dim frm As Form
        'Dim FullFormName As String = ""

        'If AssemblyName.Trim = "" Then
        '    FullFormName = System.Reflection.Assembly.GetEntryAssembly.GetName.Name & "." & FormName
        '    frm = System.Activator.CreateInstance(System.Type.GetType(FullFormName))
        'Else
        '    Dim a As System.Reflection.Assembly
        '    a = System.Reflection.Assembly.Load(AssemblyName)
        '    FullFormName = AssemblyName & "." & FormName
        '    frm = System.Activator.CreateInstance(a.GetType(FullFormName))

        'End If

        Return GenerateFrom(AssemblyName, FormName, "")

    End Function
End Module
