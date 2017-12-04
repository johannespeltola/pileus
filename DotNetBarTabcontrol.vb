Imports System.Drawing.Drawing2D

Class DotNetBarTabcontrol
    Inherits TabControl

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
        DoubleBuffered = True
        SizeMode = TabSizeMode.Fixed
        ItemSize = New Size(44, 136)
    End Sub
    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Alignment = TabAlignment.Left
    End Sub

    Dim C1 As Color = Color.FromArgb(80, 127, 207)
    Property Color1 As Color
        Get
            Return C1
        End Get
        Set(ByVal value As Color)
            C1 = value
            Invalidate()
        End Set
    End Property

    Dim C2 As Color = Color.FromArgb(100, 147, 227)
    Property Color2 As Color
        Get
            Return C2
        End Get
        Set(ByVal value As Color)
            C2 = value
            Invalidate()
        End Set
    End Property

    Dim BC As Pen = New Pen(Color.FromArgb(170, 187, 204))
    Property BorderColor As Color
        Get
            Return BC.Color
        End Get
        Set(ByVal value As Color)
            BC.Color = value
            Invalidate()
        End Set
    End Property

    Dim C3 As Color = Color.FromArgb(246, 248, 252)
    Property Color3 As Color
        Get
            Return C3
        End Get
        Set(ByVal value As Color)
            C3 = value
            Invalidate()
        End Set
    End Property

    Dim OB As Boolean = False
    Property ShowOuterBorders As Boolean
        Get
            Return OB
        End Get
        Set(ByVal value As Boolean)
            OB = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        Try : SelectedTab.BackColor = Color.White : Catch : End Try
        G.Clear(Color.White)
        G.FillRectangle(New SolidBrush(C3), New Rectangle(0, 0, ItemSize.Height + 4, Height))
        If OB Then
            G.DrawLine(BC, New Point(Width - 1, 0), New Point(Width - 1, Height - 1))    'comment out to get rid of the borders
            G.DrawLine(BC, New Point(ItemSize.Height + 1, 0), New Point(Width - 1, 0))     'comment out to get rid of the borders
            G.DrawLine(BC, New Point(ItemSize.Height + 3, Height - 1), New Point(Width - 1, Height - 1)) 'comment out to get rid of the borders
        End If
        G.DrawLine(BC, New Point(ItemSize.Height + 3, 0), New Point(ItemSize.Height + 3, 999))
        For i = 0 To TabCount - 1
            If i = SelectedIndex Then
                Dim x2 As Rectangle = New Rectangle(New Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), New Size(GetTabRect(i).Width + 3, GetTabRect(i).Height - 1))
                Dim myBlend As New ColorBlend()
                myBlend.Colors = {C1, C2, C1}
                myBlend.Positions = {0.0F, 0.5F, 1.0F}
                Dim lgBrush As New LinearGradientBrush(x2, Color.Black, Color.Black, 90.0F)
                lgBrush.InterpolationColors = myBlend
                G.FillRectangle(lgBrush, x2)
                G.DrawRectangle(BC, x2)

                G.SmoothingMode = SmoothingMode.HighQuality
                Dim p() As Point = {New Point(ItemSize.Height - 3, GetTabRect(i).Location.Y + 20), New Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 14), New Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 27)}
                G.FillPolygon(Brushes.White, p)
                G.DrawPolygon(BC, p)

                If ImageList IsNot Nothing Then
                    Try
                        If ImageList.Images(TabPages(i).ImageIndex) IsNot Nothing Then

                            G.DrawImage(ImageList.Images(TabPages(i).ImageIndex), New Point(x2.Location.X + 8, x2.Location.Y + 6))
                            G.DrawString("  " & TabPages(i).Text, Font, Brushes.White, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                        Else
                            G.DrawString(TabPages(i).Text, New Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.White, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                        End If
                    Catch ex As Exception
                        G.DrawString(TabPages(i).Text, New Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.White, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                    End Try
                Else
                    G.DrawString(TabPages(i).Text, New Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.White, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                End If

            Else
                Dim x2 As Rectangle = New Rectangle(New Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), New Size(GetTabRect(i).Width + 3, GetTabRect(i).Height + 1))
                G.FillRectangle(New SolidBrush(C3), x2)
                G.DrawLine(BC, New Point(x2.Right, x2.Top), New Point(x2.Right, x2.Bottom))
                If ImageList IsNot Nothing Then
                    Try
                        If ImageList.Images(TabPages(i).ImageIndex) IsNot Nothing Then
                            G.DrawImage(ImageList.Images(TabPages(i).ImageIndex), New Point(x2.Location.X + 8, x2.Location.Y + 6))
                            G.DrawString("  " & TabPages(i).Text, Font, Brushes.DimGray, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                        Else
                            G.DrawString(TabPages(i).Text, Font, Brushes.DimGray, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                        End If
                    Catch ex As Exception
                        G.DrawString(TabPages(i).Text, Font, Brushes.DimGray, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                    End Try
                Else
                    G.DrawString(TabPages(i).Text, Font, Brushes.DimGray, x2, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
                End If
            End If
        Next

        e.Graphics.DrawImage(B.Clone, 0, 0)
        G.Dispose() : B.Dispose()
    End Sub
End Class