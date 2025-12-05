Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        lblTotal.Text = "₱0.00"
    End Sub

    Public Sub UpdateTotal()
        lblTotal.Text = "₱" & Cart.GetTotal().ToString("N2")
    End Sub

    Public Sub LoadFormInPanel(childForm As Form)
        Panel2.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel2.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub btnTop_Click(sender As Object, e As EventArgs) Handles btnTop.Click
        LoadFormInPanel(New Top(Me))
    End Sub

    Private Sub btnBottoms_Click(sender As Object, e As EventArgs) Handles btnBottoms.Click
        LoadFormInPanel(New Bottoms(Me))
    End Sub

    Private Sub btnFootwear_Click(sender As Object, e As EventArgs) Handles btnFootwear.Click
        LoadFormInPanel(New Footwear(Me))
    End Sub

    Private Sub btnAccessories_Click(sender As Object, e As EventArgs) Handles btnAccessories.Click
        LoadFormInPanel(New Accessories(Me))
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        LoadFormInPanel(New Inventory(Me))
    End Sub
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Dim total As Decimal = Cart.GetTotal()
        If total > 0 Then
            ' Loop through the cart items and save each product to the database
            For i As Integer = 0 To Cart.qtyTop.Length - 1
                If Cart.qtyTop(i) > 0 Then
                    Dim productName As String = GetProductNameByIndex(i) ' Replace with your logic to get product name
                    Dim price As Decimal = DBmySql.GetPrice(productName)
                    Dim quantity As Integer = Cart.qtyTop(i)

                    ' Save the checkout record
                    DBmySql.SaveCheckoutRecord(productName, price, quantity)
                End If
            Next

            ' Reset all quantities in the cart
            Cart.ResetCart()

            ' Update the UI
            lblTotal.Text = "₱0.00"
            MessageBox.Show("Checkout successful! Your total is ₱" & total.ToString("N2"), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Your cart is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
