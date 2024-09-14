Public Class Form2
    Dim _ID As Integer = 0
    Public Sub New(ID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        _ID = ID
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(Test1 As String, Test As String)

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ID As Integer, Title As String)

        ' This call is required by the designer.
        InitializeComponent()
        Label1.Text = ID
        Label2.Text = Title
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Dim _dr As DataRow

    Public Sub New(dr As DataRow)

        ' This call is required by the designer.
        InitializeComponent()

        _dr = dr
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Label1.Text = _dr("Title")

    End Sub
End Class