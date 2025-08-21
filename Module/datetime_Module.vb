Module datetime_Module

    Public Function AgeCalu(ByVal Birthdate As String) As String
        Dim birthDateText As String = Birthdate
        Dim birth_date As DateTime
        Dim TotalAge As String

        ' ตรวจสอบว่าข้อมูลใน Label เป็นวันที่ที่ถูกต้อง
        If DateTime.TryParse(birthDateText, birth_date) Then
            Dim currentDate As DateTime = DateTime.Now
            Dim totalYears As Integer = currentDate.Year - birth_date.Year

            ' ตรวจสอบว่าถึงวันเกิดปีนี้หรือยัง
            If currentDate < birth_date.AddYears(totalYears) Then
                totalYears -= 1 ' ถอยหลังหากยังไม่ถึงวันเกิดในปีปัจจุบัน
            End If

            If birth_date > DateTime.Now Then
                TotalAge = "ระบุวันที่ไม่ถูกต้อง"
                Return TotalAge
            Else
                TotalAge = String.Format("{0} ปี", totalYears)
                Return TotalAge
            End If
        Else
            TotalAge = "ไม่ระบุ" ' หากไม่ใช่วันที่ที่ถูกต้อง
            Return TotalAge
        End If
    End Function

    Public Function YearsExperCalu(ByVal StartDate As String, ByVal EndDate As String, ByVal EndDateValue As String) As String
        Dim workDateText As String = StartDate
        Dim workDate As DateTime
        Dim currentDate As DateTime
        Dim YearsExper As String

        ' ตรวจสอบว่าข้อมูลใน Label เป็นวันที่ที่ถูกต้อง
        If DateTime.TryParse(workDateText, workDate) Then
            If EndDate = "" Then
                currentDate = DateTime.Now
            Else
                currentDate = EndDateValue
            End If

            Dim totalYears As Integer = currentDate.Year - workDate.Year

            ' ตรวจสอบว่าถึงวันครบรอบปีในปีนี้หรือยัง
            If currentDate < workDate.AddYears(totalYears) Then
                totalYears -= 1
            End If

            Dim totalMonths As Integer = currentDate.Month - workDate.Month
            ' ตรวจสอบเดือนที่ยังไม่ถึง
            If currentDate < workDate.AddYears(totalYears).AddMonths(totalMonths) Then
                totalMonths -= 1
            End If

            ' หากจำนวนเดือนติดลบ ให้เพิ่มอีก 12 เดือน
            If totalMonths < 0 Then
                totalMonths += 12
            End If

            ' คำนวณจำนวนวันที่เหลือ
            Dim finalDate As DateTime = workDate.AddYears(totalYears).AddMonths(totalMonths)

            ' แสดงผลลัพธ์ในรูปแบบ ปี เดือน และวัน
            If workDate > DateTime.Now Then
                YearsExper = "ระบุวันที่ไม่ถูกต้อง"
                Return YearsExper
            Else
                YearsExper = String.Format("{0} ปี {1} เดือน", totalYears, totalMonths)
                Return YearsExper
            End If
        Else
            YearsExper = "ไม่ระบุ" ' หากไม่ใช่วันที่ที่ถูกต้อง
            Return YearsExper
        End If
    End Function
End Module
