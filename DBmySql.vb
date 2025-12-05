Imports MySql.Data.MySqlClient

Module DBmySql
    Private ReadOnly connectionString As String = "server=localhost; userid=root; password=; database=coziest; port=3306;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function


    Public Function GetProductsByCategory(category As String) As DataTable
        Using conn = GetConnection()
            conn.Open()
            Dim query As String = "SELECT id, product_name, category, price, stock FROM products WHERE category = @category ORDER BY id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@category", category)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                Return dt
            End Using
        End Using
    End Function

    ' Get all products for inventory
    Public Function GetAllProducts() As DataTable
        Using conn = GetConnection()
            conn.Open()
            Dim query As String = "SELECT id, product_name, category, price, stock FROM products ORDER BY category, id"
            Using cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                Return dt
            End Using
        End Using
    End Function

    ' Get stock by product name
    Public Function GetStock(itemName As String) As Integer
        Using conn = GetConnection()
            conn.Open()
            Dim query As String = "SELECT stock FROM products WHERE product_name = @name LIMIT 1"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", itemName)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Return Convert.ToInt32(result)
                Else
                    Return 0
                End If
            End Using
        End Using
    End Function

    ' Get price by product name
    Public Function GetPrice(itemName As String) As Decimal
        Using conn = GetConnection()
            conn.Open()
            Dim query As String = "SELECT price FROM products WHERE product_name = @name LIMIT 1"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", itemName)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Return Convert.ToDecimal(result)
                Else
                    Return 0D
                End If
            End Using
        End Using
    End Function

    ' Reduce stock
    Public Sub ReduceStock(itemName As String, qty As Integer)
        Using conn = GetConnection()
            conn.Open()
            Dim query As String = "UPDATE products SET stock = stock - @qty WHERE product_name = @name"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@qty", qty)
                cmd.Parameters.AddWithValue("@name", itemName)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Update stock (for inventory management)
    Public Sub UpdateStock(productId As Integer, newStock As Integer)
        Using conn = GetConnection()
            conn.Open()
            Dim query As String = "UPDATE products SET stock = @stock WHERE id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@stock", newStock)
                cmd.Parameters.AddWithValue("@id", productId)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Save checkout record
    Public Sub SaveCheckoutRecord(productName As String, price As Decimal, quantity As Integer)
        Using conn = GetConnection()
            conn.Open()
            Dim query As String = "INSERT INTO checkout_records (product_name, price, quantity, total_price) VALUES (@productName, @price, @quantity, @totalPrice)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@productName", productName)
                cmd.Parameters.AddWithValue("@price", price)
                cmd.Parameters.AddWithValue("@quantity", quantity)
                cmd.Parameters.AddWithValue("@totalPrice", price * quantity)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    ' Get product name by index (example logic)
    Public Function GetProductNameByIndex(index As Integer) As String
        Using conn = GetConnection()
            conn.Open()
            Dim query As String = "SELECT product_name FROM products WHERE id = @id LIMIT 1"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", index + 1) ' Assuming index corresponds to product ID
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Return result.ToString()
                Else
                    Return String.Empty
                End If
            End Using
        End Using
    End Function
End Module