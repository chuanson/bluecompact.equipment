Imports System.Drawing
Imports System.Drawing.Imaging
Imports ZXing
Imports ZXing.Common

Module barcode_Module
    Public Sub GenerateBarcode_POS(ByVal text As String, ByRef pictureBox As PictureBox)
        Try
            ' สร้าง BarcodeWriter
            Dim writer As New BarcodeWriterPixelData() With {
                .Format = BarcodeFormat.EAN_13,
                .Options = New EncodingOptions() With {
                    .Height = 48,
                    .Width = 158,
                    .Margin = 10
                }
            }
            ' สร้าง Barcode
            Dim pixelData = writer.Write(text)
            ' แปลงเป็น Bitmap
            Using bitmap As New Bitmap(pixelData.Width, pixelData.Height, PixelFormat.Format32bppRgb)
                Dim bitmapData = bitmap.LockBits(New Rectangle(0, 0, pixelData.Width, pixelData.Height),
                                                ImageLockMode.WriteOnly,
                                                PixelFormat.Format32bppRgb)
                Try
                    ' คัดลอกข้อมูล pixel
                    Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0, pixelData.Pixels.Length)
                Finally
                    bitmap.UnlockBits(bitmapData)
                End Try
                ' แสดงใน PictureBox
                pictureBox.Image = New Bitmap(bitmap)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating barcode: " & ex.Message)
        End Try
    End Sub

    Public Sub GenerateBarcode_Warehouse(ByVal text As String, ByRef pictureBox As PictureBox)
        Try
            ' สร้าง BarcodeWriter
            Dim writer As New BarcodeWriterPixelData() With {
                .Format = BarcodeFormat.EAN_13,
                .Options = New EncodingOptions() With {
                    .Height = 48,
                    .Width = 158,
                    .Margin = 10
                }
            }
            ' สร้าง Barcode
            Dim pixelData = writer.Write(text)
            ' แปลงเป็น Bitmap
            Using bitmap As New Bitmap(pixelData.Width, pixelData.Height, PixelFormat.Format32bppRgb)
                Dim bitmapData = bitmap.LockBits(New Rectangle(0, 0, pixelData.Width, pixelData.Height),
                                                ImageLockMode.WriteOnly,
                                                PixelFormat.Format32bppRgb)
                Try
                    ' คัดลอกข้อมูล pixel
                    Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0, pixelData.Pixels.Length)
                Finally
                    bitmap.UnlockBits(bitmapData)
                End Try
                ' แสดงใน PictureBox
                pictureBox.Image = New Bitmap(bitmap)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating barcode: " & ex.Message)
        End Try
    End Sub
End Module
