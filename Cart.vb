Public Class Cart
    Public Shared qtyTop(8) As Integer
    Public Shared qtyBottoms(8) As Integer
    Public Shared qtyFootwear(5) As Integer  ' Changed to 5 since you have 6 footwear items (0-5)
    Public Shared qtyAccessories(5) As Integer  ' Changed to 5 since you have 6 accessories (0-5)

    ' Product names for database lookup
    Public Shared topProducts As String() = {
        "Signature Script Tee",
        "Monochrome Statement Tee",
        "Sunshine Smile Tee",
        "Racing Stripe Tee",
        "Sky Blue Heritage Tee",
        "Flame Logo Tee",
        "Neon Flash Tee",
        "Midnight Satin Bomber",
        "Carolina Blue Varsity Hoodie"
    }

    Public Shared bottomProducts As String() = {
        "Wave Rider Boardshorts",
        "Wild Side Leopard Shorts",
        "Electric Storm Shorts",
        "Urban Essential Shorts",
        "Powder Blue 303 Shorts",
        "Gothic Edge Shorts",
        "Renaissance Art Shorts",
        "Paisley Dreams Shorts",
        "Shadow Knit Shorts"
    }

    Public Shared footwearProducts As String() = {
        "Classic Court Sneakers",
        "Midnight Slide Sandals",
        "Expedition Olive Sandals",
        "Desert Dune Sandals",
        "Earth Tone Sandals",
        "Stealth Black Sandals"
    }

    Public Shared accessoryProducts As String() = {
        "Performance Sweatband",
        "Elite Crossbody Bag",
        "Face Shield Balaclava",
        "Heritage Explorer Backpack",
        "Coziest Sticker Pack",
        "Coziest Lanyard"
    }

    Public Shared Function GetTotal() As Decimal
        Dim total As Decimal = 0

        ' Calculate Tops
        For i = 0 To 8
            If qtyTop(i) > 0 Then
                total += qtyTop(i) * DBmySql.GetPrice(topProducts(i))
            End If
        Next

        ' Calculate Bottoms
        For i = 0 To 8
            If qtyBottoms(i) > 0 Then
                total += qtyBottoms(i) * DBmySql.GetPrice(bottomProducts(i))
            End If
        Next

        ' Calculate Footwear
        For i = 0 To 5
            If qtyFootwear(i) > 0 Then
                total += qtyFootwear(i) * DBmySql.GetPrice(footwearProducts(i))
            End If
        Next

        ' Calculate Accessories
        For i = 0 To 5
            If qtyAccessories(i) > 0 Then
                total += qtyAccessories(i) * DBmySql.GetPrice(accessoryProducts(i))
            End If
        Next

        Return total
    End Function

    Public Shared Sub ResetCart()
        ' Reset quantities for Accessories
        For i As Integer = 0 To qtyAccessories.Length - 1
            qtyAccessories(i) = 0
        Next

        ' Reset quantities for Top
        For i As Integer = 0 To qtyTop.Length - 1
            qtyTop(i) = 0
            qtyBottoms(i) = 0
        Next

        For i = 0 To 5
            qtyFootwear(i) = 0
            qtyAccessories(i) = 0
        Next
    End Sub

    ' Process checkout - reduce stock for all items in cart
    Public Shared Sub ProcessCheckout()
        For i = 0 To 8
            If qtyTop(i) > 0 Then
                DBmySql.ReduceStock(topProducts(i), qtyTop(i))
            End If
            If qtyBottoms(i) > 0 Then
                DBmySql.ReduceStock(bottomProducts(i), qtyBottoms(i))
            End If
        Next

        For i = 0 To 5
            If qtyFootwear(i) > 0 Then
                DBmySql.ReduceStock(footwearProducts(i), qtyFootwear(i))
            End If
            If qtyAccessories(i) > 0 Then
                DBmySql.ReduceStock(accessoryProducts(i), qtyAccessories(i))
            End If
        Next

        ResetCart()
    End Sub
End Class