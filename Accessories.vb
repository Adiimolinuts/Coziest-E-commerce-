Public Class Accessories
    Private mainForm As Form1

    Public Sub New(frm As Form1)
        InitializeComponent()
        mainForm = frm
    End Sub

    Private Sub Accessories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Refresh        ' Refresh quantities from Cart
        lblQty111.Text = Cart.qtyAccessories(0)
        lblQty112.Text = Cart.qtyAccessories(1)
        lblQty113.Text = Cart.qtyAccessories(2)
        lblQty114.Text = Cart.qtyAccessories(3)
        lblQty115.Text = Cart.qtyAccessories(4)
        lblQty116.Text = Cart.qtyAccessories(5)

        mainForm.UpdateTotal()
    End Sub


    ' ============================================================
    ' ITEM 1 (Index 0)
    ' ============================================================

    Private Sub btnPlus111_Click(sender As Object, e As EventArgs) Handles btnPlus111.Click
        Cart.qtyAccessories(0) += 1
        lblQty111.Text = Cart.qtyAccessories(0)
        mainForm.UpdateTotal()
    End Sub

    Private Sub btnMinus111_Click(sender As Object, e As EventArgs) Handles btnMinus111.Click
        If Cart.qtyAccessories(0) > 0 Then Cart.qtyAccessories(0) -= 1
        lblQty111.Text = Cart.qtyAccessories(0)
        mainForm.UpdateTotal()
    End Sub


    ' ============================================================
    ' ITEM 2 (Index 1)
    ' ============================================================

    Private Sub btnPlus112_Click(sender As Object, e As EventArgs) Handles btnPlus112.Click
        Cart.qtyAccessories(1) += 1
        lblQty112.Text = Cart.qtyAccessories(1)
        mainForm.UpdateTotal()
    End Sub

    Private Sub btnMinus112_Click(sender As Object, e As EventArgs) Handles btnMinus112.Click
        If Cart.qtyAccessories(1) > 0 Then Cart.qtyAccessories(1) -= 1
        lblQty112.Text = Cart.qtyAccessories(1)
        mainForm.UpdateTotal()
    End Sub


    ' ============================================================
    ' ITEM 3 (Index 2)
    ' ============================================================

    Private Sub btnPlus113_Click(sender As Object, e As EventArgs) Handles btnPlus113.Click
        Cart.qtyAccessories(2) += 1
        lblQty113.Text = Cart.qtyAccessories(2)
        mainForm.UpdateTotal()
    End Sub

    Private Sub btnMinus113_Click(sender As Object, e As EventArgs) Handles btnMinus113.Click
        If Cart.qtyAccessories(2) > 0 Then Cart.qtyAccessories(2) -= 1
        lblQty113.Text = Cart.qtyAccessories(2)
        mainForm.UpdateTotal()
    End Sub


    ' ============================================================
    ' ITEM 4 (Index 3)
    ' ============================================================

    Private Sub btnPlus114_Click(sender As Object, e As EventArgs) Handles btnPlus114.Click
        Cart.qtyAccessories(3) += 1
        lblQty114.Text = Cart.qtyAccessories(3)
        mainForm.UpdateTotal()
    End Sub

    Private Sub btnMinus114_Click(sender As Object, e As EventArgs) Handles btnMinus114.Click
        If Cart.qtyAccessories(3) > 0 Then Cart.qtyAccessories(3) -= 1
        lblQty114.Text = Cart.qtyAccessories(3)
        mainForm.UpdateTotal()
    End Sub


    ' ============================================================
    ' ITEM 5 (Index 4)
    ' ============================================================

    Private Sub btnPlus115_Click(sender As Object, e As EventArgs) Handles btnPlus115.Click
        Cart.qtyAccessories(4) += 1
        lblQty115.Text = Cart.qtyAccessories(4)
        mainForm.UpdateTotal()
    End Sub

    Private Sub btnMinus115_Click(sender As Object, e As EventArgs) Handles btnMinus115.Click
        If Cart.qtyAccessories(4) > 0 Then Cart.qtyAccessories(4) -= 1
        lblQty115.Text = Cart.qtyAccessories(4)
        mainForm.UpdateTotal()
    End Sub


    ' ============================================================
    ' ITEM 6 (Index 5)
    ' ============================================================

    Private Sub btnPlus116_Click(sender As Object, e As EventArgs) Handles btnPlus116.Click
        Cart.qtyAccessories(5) += 1
        lblQty116.Text = Cart.qtyAccessories(5)
        mainForm.UpdateTotal()
    End Sub

    Private Sub btnMinus116_Click(sender As Object, e As EventArgs) Handles btnMinus116.Click
        If Cart.qtyAccessories(5) > 0 Then Cart.qtyAccessories(5) -= 1
        lblQty116.Text = Cart.qtyAccessories(5)
        mainForm.UpdateTotal()
    End Sub


End Class
