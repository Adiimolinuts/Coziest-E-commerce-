Public Class Bottoms
    Private mainForm As Form1

    Public Sub New(frm As Form1)
        InitializeComponent()
        mainForm = frm
    End Sub

    Private Sub Bottoms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblQty11.Text = Cart.qtyBottoms(0)
        lblQty12.Text = Cart.qtyBottoms(1)
        lblQty13.Text = Cart.qtyBottoms(2)
        lblQty14.Text = Cart.qtyBottoms(3)
        lblQty15.Text = Cart.qtyBottoms(4)
        lblQty16.Text = Cart.qtyBottoms(5)
        lblQty17.Text = Cart.qtyBottoms(6)
        lblQty18.Text = Cart.qtyBottoms(7)
        lblQty19.Text = Cart.qtyBottoms(8)

        mainForm.UpdateTotal()
    End Sub


    ' ============================================================
    ' ITEM 1 (Index 0)
    ' ============================================================

    Private Sub btnPlus11_Click(sender As Object, e As EventArgs) Handles btnPlus21.Click
        Cart.qtyBottoms(0) += 1
        lblQty11.Text = Cart.qtyBottoms(0)
        mainForm.UpdateTotal()
    End Sub

    Private Sub btnMinus11_Click(sender As Object, e As EventArgs) Handles btnMinus21.Click
        If Cart.qtyBottoms(0) > 0 Then Cart.qtyBottoms(0) -= 1
        lblQty11.Text = Cart.qtyBottoms(0)
        mainForm.UpdateTotal()
    End Sub


    ' ============================================================
    ' ITEM 2 (Index 1)
    ' ============================================================

    Private Sub btnPlus12_Click(sender As Object, e As EventArgs) Handles btnPlus22.Click
        Cart.qtyBottoms(1) += 1
        lblQty12.Text = Cart.qtyBottoms(1)
        mainForm.UpdateTotal()
    End Sub

    Private Sub btnMinus12_Click(sender As Object, e As EventArgs) Handles btnMinus22.Click
        If Cart.qtyBottoms(1) > 0 Then Cart.qtyBottoms(1) -= 1
        lblQty12.Text = Cart.qtyBottoms(1)
        mainForm.UpdateTotal()
    End Sub


    ' ============================================================
    ' ITEM 3 (Index 2)
    ' ============================================================

    Private Sub btnPlus13_Click(sender As Object, e As EventArgs) Handles btnPlus23.Click
        Cart.qtyBottoms(2) += 1
        lblQty13.Text = Cart.qtyBottoms(2)
        mainForm.UpdateTotal()
    End Sub

    Private Sub btnMinus13_Click(sender As Object, e As EventArgs) Handles btnMinus23.Click
        If Cart.qtyBottoms(2) > 0 Then Cart.qtyBottoms(2) -= 1
        lblQty13.Text = Cart.qtyBottoms(2)
        mainForm.UpdateTotal()
    End Sub


    ' ============================================================
    ' ITEM 4 (Index 3)
    ' ============================================================

    Private Sub btnPlus14_Click(sender As Object, e As EventArgs) Handles btnPlus24.Click
        Cart.qtyBottoms(3) += 1
        lblQty14.Text = Cart.qtyBottoms(3)
        mainForm.UpdateTotal()
    End Sub

    Private Sub btnMinus14_Click(sender As Object, e As EventArgs) Handles btnMinus24.Click
        If Cart.qtyBottoms(3) > 0 Then Cart.qtyBottoms(3) -= 1
        lblQty14.Text = Cart.qtyBottoms(3)
        mainForm.UpdateTotal()
    End Sub


    ' ============================================================
    ' ITEM 5 (Index 4)
    ' ============================================================

    Private Sub btnPlus15_Click(sender As Object, e As EventArgs) Handles btnPlus25.Click
        Cart.qtyBottoms(4) += 1
        lblQty15.Text = Cart.qtyBottoms(4)
        mainForm.UpdateTotal()
    End Sub

    Private Sub btnMinus15_Click(sender As Object, e As EventArgs) Handles btnMinus25.Click
        If Cart.qtyBottoms(4) > 0 Then Cart.qtyBottoms(4) -= 1
        lblQty15.Text = Cart.qtyBottoms(4)
        mainForm.UpdateTotal()
    End Sub


    ' ============================================================
    ' ITEM 6 (Index 5)
    ' ============================================================

    Private Sub btnPlus16_Click(sender As Object, e As EventArgs) Handles btnPlus26.Click
        Cart.qtyBottoms(5) += 1
        lblQty16.Text = Cart.qtyBottoms(5)
        mainForm.UpdateTotal()
    End Sub

    Private Sub btnMinus16_Click(sender As Object, e As EventArgs) Handles btnMinus26.Click
        If Cart.qtyBottoms(5) > 0 Then Cart.qtyBottoms(5) -= 1
        lblQty16.Text = Cart.qtyBottoms(5)
        mainForm.UpdateTotal()
    End Sub


    ' ============================================================
    ' ITEM 7 (Index 6)
    ' ============================================================

    Private Sub btnPlus17_Click(sender As Object, e As EventArgs) Handles btnPlus27.Click
        Cart.qtyBottoms(6) += 1
        lblQty17.Text = Cart.qtyBottoms(6)
        mainForm.UpdateTotal()
    End Sub

    Private Sub btnMinus17_Click(sender As Object, e As EventArgs) Handles btnMinus27.Click
        If Cart.qtyBottoms(6) > 0 Then Cart.qtyBottoms(6) -= 1
        lblQty17.Text = Cart.qtyBottoms(6)
        mainForm.UpdateTotal()
    End Sub


    ' ============================================================
    ' ITEM 8 (Index 7)
    ' ============================================================

    Private Sub btnPlus18_Click(sender As Object, e As EventArgs) Handles btnPlus28.Click
        Cart.qtyBottoms(7) += 1
        lblQty18.Text = Cart.qtyBottoms(7)
        mainForm.UpdateTotal()
    End Sub

    Private Sub btnMinus18_Click(sender As Object, e As EventArgs) Handles btnMinus28.Click
        If Cart.qtyBottoms(7) > 0 Then Cart.qtyBottoms(7) -= 1
        lblQty18.Text = Cart.qtyBottoms(7)
        mainForm.UpdateTotal()
    End Sub


    ' ============================================================
    ' ITEM 9 (Index 8)
    ' ============================================================

    Private Sub btnPlus19_Click(sender As Object, e As EventArgs) Handles btnPlus29.Click
        Cart.qtyBottoms(8) += 1
        lblQty19.Text = Cart.qtyBottoms(8)
        mainForm.UpdateTotal()
    End Sub

    Private Sub btnMinus19_Click(sender As Object, e As EventArgs) Handles btnMinus29.Click
        If Cart.qtyBottoms(8) > 0 Then Cart.qtyBottoms(8) -= 1
        lblQty19.Text = Cart.qtyBottoms(8)
        mainForm.UpdateTotal()
    End Sub

End Class
