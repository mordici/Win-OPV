Public Class Form1

    Private Sub очиститьПоляToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles очиститьПоляToolStripMenuItem.Click
        textBox1.Text = "0"
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox7.Text = ""
        textBox8.Text = ""
        textBox9.Text = ""
        textBox10.Text = ""
        textBox11.Text = ""
        textBox14.Text = ""
        comboBox1.Text = ""
        comboBox2.Text = ""
        textBox15.Text = ""
        textBox17.Text = ""
        textBox8.BackColor = System.Drawing.Color.White
        textBox7.BackColor = System.Drawing.Color.White
        textBox9.BackColor = System.Drawing.Color.White
        textBox15.BackColor = System.Drawing.Color.White
        textBox17.BackColor = System.Drawing.Color.White
    End Sub

    Private Sub сохранитьВФайлToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles сохранитьВФайлToolStripMenuItem1.Click
        Dim fp As String = "analiz.txt"
        My.Computer.FileSystem.DeleteFile(fp)
        My.Computer.FileSystem.WriteAllText(fp, "Жесткость (мг-экв/л)", True)
        My.Computer.FileSystem.WriteAllText(fp, vbNewLine, True)
        My.Computer.FileSystem.WriteAllText(fp, textBox2.Text, True)
        My.Computer.FileSystem.WriteAllText(fp, vbNewLine, True)
        My.Computer.FileSystem.WriteAllText(fp, "Кальций (мг/л)", True)
        My.Computer.FileSystem.WriteAllText(fp, vbNewLine, True)
        My.Computer.FileSystem.WriteAllText(fp, textBox3.Text, True)
        My.Computer.FileSystem.WriteAllText(fp, vbNewLine, True)
        My.Computer.FileSystem.WriteAllText(fp, "Магний (мг/л)", True)
        My.Computer.FileSystem.WriteAllText(fp, vbNewLine, True)
        My.Computer.FileSystem.WriteAllText(fp, textBox4.Text, True)
        My.Computer.FileSystem.WriteAllText(fp, vbNewLine, True)
        My.Computer.FileSystem.WriteAllText(fp, "Гидрокарбонаты (мг/л)", True)
        My.Computer.FileSystem.WriteAllText(fp, vbNewLine, True)
        My.Computer.FileSystem.WriteAllText(fp, textBox6.Text, True)
        My.Computer.FileSystem.WriteAllText(fp, vbNewLine, True)
        My.Computer.FileSystem.WriteAllText(fp, "Мутность (мг/л)", True)
        My.Computer.FileSystem.WriteAllText(fp, vbNewLine, True)
        My.Computer.FileSystem.WriteAllText(fp, textBox11.Text, True)
        My.Computer.FileSystem.WriteAllText(fp, vbNewLine, True)
        My.Computer.FileSystem.WriteAllText(fp, "Аммиак (мг/л)", True)
        My.Computer.FileSystem.WriteAllText(fp, vbNewLine, True)
        My.Computer.FileSystem.WriteAllText(fp, textBox14.Text, True)
        timer1.Start()
        notifyIcon1.BalloonTipTitle = "WinOPV 2"
        notifyIcon1.BalloonTipText = "Записано в файл"
        notifyIcon1.Visible = True
        notifyIcon1.ShowBalloonTip(0)
    End Sub

    Private Sub открытьФайлАнализаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles открытьФайлАнализаToolStripMenuItem.Click
        Shell("notepad analiz.txt", vbNormalFocus)
    End Sub

    Private Sub немецкийГрадусToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles немецкийГрадусToolStripMenuItem1.Click
        textBox2.Text = textBox1.Text
        label2.Text = "Жесткость (нем. гр.)"
    End Sub

    Private Sub французскийГрадусToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles французскийГрадусToolStripMenuItem1.Click
        Dim a As String, b As String
        a = textBox1.Text
        b = a * 1.785
        textBox2.Text = b
        label2.Text = "Жесткость (фр. гр.)"
    End Sub

    Private Sub ммольлToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ммольлToolStripMenuItem.Click
        Dim a As String, b As String
        a = textBox1.Text
        b = a * 0.1783
        textBox2.Text = b
        label2.Text = "Жесткость (ммоль/л)"
    End Sub

    Private Sub мглToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles мглToolStripMenuItem.Click
        Dim a As String, b As String
        a = textBox1.Text
        b = a * 17.85
        textBox2.Text = b
        label2.Text = "Жесткость (мг/л)"
    End Sub

    Private Sub дебитомерToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles дебитомерToolStripMenuItem.Click
        Shell("dm.exe", vbNormalFocus)
    End Sub

    Private Sub команднаяСтрокаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles команднаяСтрокаToolStripMenuItem.Click
        Shell("cmd", vbNormalFocus)
    End Sub

    Private Sub стандартнаяToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles стандартнаяToolStripMenuItem.Click
        menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        My.Computer.FileSystem.DeleteFile("theme.ini")
        My.Computer.FileSystem.WriteAllText("theme.ini", "theme=std", True)
    End Sub

    Private Sub windowsXPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles windowsXPToolStripMenuItem.Click
        menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        My.Computer.FileSystem.DeleteFile("theme.ini")
        My.Computer.FileSystem.WriteAllText("theme.ini", "theme=xp", True)
    End Sub

    Private Sub пакетОбновленияToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("CScript sp.vbs", vbNormalFocus)
    End Sub

    Private Sub информацияToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles информацияToolStripMenuItem.Click
        Shell("info.exe", vbNormalFocus)
    End Sub

    Private Sub беларускаяМоваToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles беларускаяМоваToolStripMenuItem1.Click
        groupBox1.Text = "Кальцый, магнiй"
        groupBox2.Text = "Аміяк"
        groupBox3.Text = "Мутнасьць"
        groupBox4.Text = "Гідракарбанаты"
        label1.Text = "К-сьць кропель да зялёнага колеру"
        label2.Text = "Калянасьць (мґ-экв/л)"
        label3.Text = "Кальцый"
        label4.Text = "Mагнiй"
        label5.Text = "К-сьць кропель да жоўтага колеру"
        label6.Text = "Гiдракарбанаты (мґ/л)"
        label8.Text = "Набярыце мутнасьць у NTU"
        label9.Text = "Мутнасьць (мґ/л)"
        label10.Text = "Набярыце рН (для драбей - коска)"
        label11.Text = "Набярыце амонiй"
        label12.Text = "Аміяк"
        button1.Text = "Падлік"
        button2.Text = "Падлік"
        button3.Text = "Падлік"
        button4.Text = "Падлік"
        ммольлToolStripMenuItem.Text = "ммоль/л"
        единицыToolStripMenuItem.Text = "Адзінкі"
        немецкийГрадусToolStripMenuItem1.Text = "Нямецкі градус"
        французскийГрадусToolStripMenuItem1.Text = "Французскі градус"
        файлToolStripMenuItem.Text = "Файл"
        очиститьПоляToolStripMenuItem.Text = "Ачысьціць паля"
        сохранитьВФайлToolStripMenuItem1.Text = "Захаваць у файл"
        сервисToolStripMenuItem.Text = "Сэрвіс"
        дебитомерToolStripMenuItem.Text = "Дэбітамер"
        команднаяСтрокаToolStripMenuItem.Text = "Камандны радок"
        темаОформленияToolStripMenuItem.Text = "Тэма афармленьня"
        информацияToolStripMenuItem.Text = "Інфармацыя"
        оПрограммеToolStripMenuItem.Text = "Мова"
        закрытьToolStripMenuItem.Text = "Закрыць"
        открытьФайлАнализаToolStripMenuItem.Text = "Адкрыць файл аналіза"
        groupBox5.Text = "Канверцер адзінкаў жорсткасьці"
        label7.Text = "Адзінка 1"
        label13.Text = "Перакласьці ў: "
        label14.Text = "Рэзультат"
        My.Computer.FileSystem.DeleteFile("lang.ini")
        My.Computer.FileSystem.WriteAllText("lang.ini", "lang=be", True)
    End Sub

    Private Sub belaruskaäMovalacinkaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles belaruskaäMovalacinkaToolStripMenuItem.Click
        groupBox1.Text = "Kaľcyj, magnij"
        groupBox2.Text = "Amiäk"
        groupBox3.Text = "Mutnaść"
        groupBox4.Text = "Gidrakarbanaty"
        label1.Text = "K-ść kropľaú da zäľonaga koleru"
        label2.Text = "Kaľanaść (mģ/ékv-l)"
        label3.Text = "Kaľcyj"
        label4.Text = "Magnij"
        label5.Text = "K-ść kropľaú da žoútaga koleru"
        label6.Text = "Gidrakarbanaty (mģ/l)"
        label8.Text = "Nabäryce mutnaść u NTU"
        label9.Text = "Mutnaść (mģ/l)"
        label10.Text = "Nabäryce рН (dlä drabej - koska)"
        label11.Text = "Nabäryce amonij"
        label12.Text = "Amiäk"
        button1.Text = "Padlik"
        button2.Text = "Padlik"
        button3.Text = "Padlik"
        button4.Text = "Padlik"
        ммольлToolStripMenuItem.Text = "mmoľ/l"
        единицыToolStripMenuItem.Text = "Aďinki"
        немецкийГрадусToolStripMenuItem1.Text = "Ňamecki gradus"
        французскийГрадусToolStripMenuItem1.Text = "Francuzski gradus"
        файлToolStripMenuItem.Text = "Fajl"
        очиститьПоляToolStripMenuItem.Text = "Ačyścić paľa"
        сохранитьВФайлToolStripMenuItem1.Text = "Zahavać u fajl"
        сервисToolStripMenuItem.Text = "Sérvis"
        дебитомерToolStripMenuItem.Text = "Débitamer"
        команднаяСтрокаToolStripMenuItem.Text = "Kamandny radok"
        темаОформленияToolStripMenuItem.Text = "Téma afarmleńňa"
        информацияToolStripMenuItem.Text = "Infarmacyä"
        оПрограммеToolStripMenuItem.Text = "Mova"
        закрытьToolStripMenuItem.Text = "Zakryć"
        открытьФайлАнализаToolStripMenuItem.Text = "Adkryć fajl analiza"
        groupBox5.Text = "Kanvercer aďinkaú žorstkaści"
        label7.Text = "Aďinka 1:"
        label13.Text = "Peraklaści ú: "
        label14.Text = "Rézuľtat"
        My.Computer.FileSystem.DeleteFile("lang.ini")
        My.Computer.FileSystem.WriteAllText("lang.ini", "lang=bl", True)
    End Sub

    Private Sub українськаМоваToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles українськаМоваToolStripMenuItem.Click
        groupBox1.Text = "Кальцій, магній"
        groupBox2.Text = "Аміак"
        groupBox3.Text = "Мутність"
        groupBox4.Text = "Гідрокарбонати"
        label1.Text = "К-сть крапель до зеленого кольору"
        label2.Text = "Жорсткість (мг-екв/л)"
        label3.Text = "Кальцій"
        label4.Text = "Магній"
        label5.Text = "К-сть крапель до зеленого кольору"
        label6.Text = "Гідрокарбонати"
        label8.Text = "Наберите мутность в NTU"
        label9.Text = "Мутность (мг/л)"
        label10.Text = "Наберите рН (для дробів - коска)"
        label11.Text = "Наберите амоній"
        label12.Text = "Аміак"
        button1.Text = "Підрахунок"
        button2.Text = "Підрахунок"
        button3.Text = "Підрахунок"
        button4.Text = "Підрахунок"
        ммольлToolStripMenuItem.Text = "mmoль/л"
        единицыToolStripMenuItem.Text = "Одиницi"
        немецкийГрадусToolStripMenuItem1.Text = "Німецькій градус"
        французскийГрадусToolStripMenuItem1.Text = "Французській градус"
        файлToolStripMenuItem.Text = "Файл"
        очиститьПоляToolStripMenuItem.Text = "Очистити поля"
        сохранитьВФайлToolStripMenuItem1.Text = "Зберегти в файл"
        сервисToolStripMenuItem.Text = "Сервис"
        дебитомерToolStripMenuItem.Text = "Дебитомер"
        команднаяСтрокаToolStripMenuItem.Text = "Командний рядок"
        темаОформленияToolStripMenuItem.Text = "Тема оформлення"
        информацияToolStripMenuItem.Text = "Інформація"
        оПрограммеToolStripMenuItem.Text = "Мова"
        закрытьToolStripMenuItem.Text = "Закрити"
        открытьФайлАнализаToolStripMenuItem.Text = "Одкрити файл аналіза"
        groupBox5.Text = "Конвертер одиниц жорсткіcти"
        label7.Text = "Одиниця 1"
        label13.Text = "Переведено в: "
        label14.Text = "Результат"
        My.Computer.FileSystem.DeleteFile("lang.ini")
        My.Computer.FileSystem.WriteAllText("lang.ini", "lang=uk", True)
    End Sub

    Private Sub englishToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles englishToolStripMenuItem1.Click
        groupBox1.Text = "Calcium, magnesium"
        groupBox2.Text = "Ammonia"
        groupBox3.Text = "Turbidity"
        groupBox4.Text = "Hydrocarbonates"
        label1.Text = "Number of drops to green color"
        label2.Text = "Water hardness (mg/equiv-l)"
        label3.Text = "Calcium"
        label4.Text = "Magnesium"
        label5.Text = "Number of drops to yellow color"
        label6.Text = "Hydrocarbonates (mg/l)"
        label8.Text = "Type turbidity in NTU"
        label9.Text = "Turbidity (mg/l)"
        label10.Text = "Type рН (for fractions - comma)"
        label11.Text = "Type ammonium"
        label12.Text = "Ammoniа"
        button1.Text = "Count"
        button2.Text = "Count"
        button3.Text = "Count"
        button4.Text = "Count"
        ммольлToolStripMenuItem.Text = "mmol/l"
        единицыToolStripMenuItem.Text = "Units"
        немецкийГрадусToolStripMenuItem1.Text = "German degree"
        французскийГрадусToolStripMenuItem1.Text = "French degree"
        файлToolStripMenuItem.Text = "File"
        очиститьПоляToolStripMenuItem.Text = "Clear"
        сохранитьВФайлToolStripMenuItem1.Text = "Save to file"
        сервисToolStripMenuItem.Text = "Services"
        дебитомерToolStripMenuItem.Text = "Debitomer"
        команднаяСтрокаToolStripMenuItem.Text = "Comand line"
        темаОформленияToolStripMenuItem.Text = "Theme"
        информацияToolStripMenuItem.Text = "Information"
        оПрограммеToolStripMenuItem.Text = "Language"
        закрытьToolStripMenuItem.Text = "Close"
        мглToolStripMenuItem.Text = "mg/l"
        открытьФайлАнализаToolStripMenuItem.Text = "Open file"
        groupBox5.Text = "Water hardness converter"
        label7.Text = "Unit 1"
        label13.Text = "Convert to: "
        label14.Text = "Result"
        My.Computer.FileSystem.DeleteFile("lang.ini")
        My.Computer.FileSystem.WriteAllText("lang.ini", "lang=en", True)
    End Sub

    Private Sub русскийЯзыкToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles русскийЯзыкToolStripMenuItem.Click
        groupBox1.Text = "Кальций, магний"
        groupBox2.Text = "Аммиак"
        groupBox3.Text = "Мутность"
        groupBox4.Text = "Гидрокарбонаты"
        label1.Text = "Кол-во капель до зеленого цвета"
        label2.Text = "Жесткость (мг-экв/л)"
        label3.Text = "Кальций"
        label4.Text = "Магний"
        label5.Text = "Кол-во капель до зеленого цвета"
        label6.Text = "Гидрокарбонаты"
        label8.Text = "Наберите мутность в NTU"
        label9.Text = "Мутность (мг/л)"
        label10.Text = "Наберите рН (для дробей - запятая)"
        label11.Text = "Наберите аммоний"
        label12.Text = "Аммиак"
        button1.Text = "Подсчет"
        button2.Text = "Подсчет"
        button3.Text = "Подсчет"
        button4.Text = "Подсчет"
        ммольлToolStripMenuItem.Text = "mmoль/л"
        единицыToolStripMenuItem.Text = "Единицы"
        немецкийГрадусToolStripMenuItem1.Text = "Немецкий градус"
        французскийГрадусToolStripMenuItem1.Text = "Французский градус"
        файлToolStripMenuItem.Text = "Файл"
        очиститьПоляToolStripMenuItem.Text = "Очистить поля"
        сохранитьВФайлToolStripMenuItem1.Text = "Сохранить в файл"
        сервисToolStripMenuItem.Text = "Сервисы"
        дебитомерToolStripMenuItem.Text = "Дебитомер"
        команднаяСтрокаToolStripMenuItem.Text = "Командная строка"
        темаОформленияToolStripMenuItem.Text = "Темы оформления"
        информацияToolStripMenuItem.Text = "Информация"
        оПрограммеToolStripMenuItem.Text = "Язык"
        закрытьToolStripMenuItem.Text = "Закрыть"
        открытьФайлАнализаToolStripMenuItem.Text = "Открыть файл анализа"
        groupBox5.Text = "Конвертер единиц жесткости"
        label7.Text = "Единица 1"
        label13.Text = "Перевести в: "
        label14.Text = "Результат"
        My.Computer.FileSystem.DeleteFile("lang.ini")
        My.Computer.FileSystem.WriteAllText("lang.ini", "lang=ru", True)
    End Sub

    Private Sub закрытьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles закрытьToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim a As String, b As String, c As String, d As String
        a = textBox1.Text
        b = a * 0.3566
        c = a * 6.7134
        d = a * 4.0736
        textBox2.Text = b
        textBox3.Text = c
        If c > 100 Then
            textBox8.Text = "Превышение"
            textBox8.BackColor = System.Drawing.Color.Red
        Else
            textBox8.Text = "Норма"
            textBox8.BackColor = System.Drawing.Color.LimeGreen
        End If
        textBox4.Text = d
        If d > 85 Then
            textBox9.Text = "Очень опасно"
            textBox9.BackColor = System.Drawing.Color.Red
        Else
            textBox9.Text = "Норма"
            textBox9.BackColor = System.Drawing.Color.LimeGreen
        End If
        единицыToolStripMenuItem.Enabled = True
        timer1.Start()
        notifyIcon1.BalloonTipTitle = "WinOPV 2"
        notifyIcon1.BalloonTipText = "Подсчет выполнен"
        notifyIcon1.Visible = True
        notifyIcon1.ShowBalloonTip(0)
    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        If textBox1.Text > 0 Then
            textBox1.Text = textBox1.Text - 1
        End If
    End Sub

    Private Sub button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button7.Click
        If textBox1.Text >= 0 Then
            textBox1.Text = textBox1.Text + 1
        End If
    End Sub

    Private Sub button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button11.Click
        If textBox10.Text > 0 Then
            textBox10.Text = textBox10.Text - 1
        End If
    End Sub

    Private Sub button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button12.Click
        If textBox10.Text >= 0 Then
            textBox10.Text = textBox10.Text + 1
        End If
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        Dim a As String, b As String
        a = textBox10.Text
        If RadioButton1.Checked Then
            b = a * 0.58
            textBox11.Text = b
            If b > 2 Then
                textBox17.Text = "Превышение"
                textBox17.BackColor = System.Drawing.Color.Red
            Else
                textBox17.Text = "Норма"
                textBox17.BackColor = System.Drawing.Color.LimeGreen
            End If
        End If
        If RadioButton2.Checked Then
            b = a * 0.13
            textBox11.Text = b
            If b > 2 Then
                textBox17.Text = "Превышение"
                textBox17.BackColor = System.Drawing.Color.Red
            Else
                textBox17.Text = "Норма"
                textBox17.BackColor = System.Drawing.Color.LimeGreen
            End If
        End If
        timer1.Start()
        notifyIcon1.BalloonTipTitle = "WinOPV 2"
        notifyIcon1.BalloonTipText = "Подсчет выполнен"
        notifyIcon1.Visible = True
        notifyIcon1.ShowBalloonTip(0)
    End Sub

    Private Sub button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button9.Click
        If textBox5.Text > 0 Then
            textBox5.Text = textBox5.Text - 1
        End If
    End Sub

    Private Sub button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button10.Click
        If textBox5.Text >= 0 Then
            textBox5.Text = textBox5.Text + 1
        End If
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Dim a As String, b As String
        a = textBox5.Text
        b = a * 17.85
        textBox6.Text = b
        If b > 400 Then
            textBox7.Text = "Превышение"
            textBox7.BackColor = System.Drawing.Color.Red
        Else
            textBox7.Text = "Норма"
            textBox7.BackColor = System.Drawing.Color.LimeGreen
        End If
        timer1.Start()
        notifyIcon1.BalloonTipTitle = "WinOPV 2"
        notifyIcon1.BalloonTipText = "Подсчет выполнен"
        notifyIcon1.Visible = True
        notifyIcon1.ShowBalloonTip(0)
    End Sub

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        Dim a As String, b As String, c As String
        a = comboBox1.Text
        b = comboBox2.Text
        If a = 7 And b = 1 Then
            textBox14.Text = "0.006"
            textBox15.Text = "Норма"
        End If
        If a = 7 And b = 2 Then
            textBox14.Text = "0.014"
            textBox15.Text = "Норма"
        End If
        If a = 7 And b = 5 Then
            textBox14.Text = "0.029"
            textBox15.Text = "Опасное содержание"
        End If
        If a = 7 And b = 10 Then
            textBox14.Text = "0.057"
            textBox15.Text = "Опасное содержание"
        End If
        If a = "7,5" And b = 1 Then
            textBox14.Text = "0.018"
            textBox15.Text = "Норма"
        End If
        If a = "7,5" And b = 2 Then
            textBox14.Text = "0.036"
            textBox15.Text = "Опасное содержание"
        End If
        If a = "7,5" And b = 5 Then
            textBox14.Text = "0.090"
            textBox15.Text = "Опасное содержание"
        End If
        If a = "7,5" And b = 10 Then
            textBox14.Text = "0.179"
            textBox15.Text = "Нельзя пить"
        End If
        If a = 8 And b = 1 Then
            textBox14.Text = "0.054"
            textBox15.Text = "Опасное содержание"
        End If
        If a = 8 And b = 2 Then
            textBox14.Text = "0.109"
            textBox15.Text = "Опасное содержание"
        End If
        If a = 8 And b = 5 Then
            textBox14.Text = "0.272"
            textBox15.Text = "Нельзя пить"
        End If
        If a = 8 And b = 10 Then
            textBox14.Text = "0.544"
            textBox15.Text = "Нельзя пить"
        End If
        If a = "8,5" And b = 1 Then
            textBox14.Text = "0.154"
            textBox15.Text = "Опасное содержание"
        End If
        If a = "8,5" And b = 2 Then
            textBox14.Text = "0.308"
            textBox15.Text = "Нельзя пить"
        End If
        If a = "8,5" And b = 5 Then
            textBox14.Text = "0.770"
            textBox15.Text = "Нельзя пить"
        End If
        If a = "8,5" And b = 10 Then
            textBox14.Text = "1.540"
            textBox15.Text = "Нельзя пить"
        End If
        c = textBox15.Text
        Select Case (c)
            Case "Норма"
                textBox15.BackColor = System.Drawing.Color.LimeGreen
            Case "Опасное содержание"
                textBox15.BackColor = System.Drawing.Color.Yellow
            Case "Нельзя пить"
                textBox15.BackColor = System.Drawing.Color.Red
        End Select
        timer1.Start()
        notifyIcon1.BalloonTipTitle = "WinOPV 2"
        notifyIcon1.BalloonTipText = "Подсчет выполнен"
        notifyIcon1.Visible = True
        notifyIcon1.ShowBalloonTip(0)
    End Sub

    Private Sub button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button13.Click
        Dim z As String = textBox12.Text
        Dim r As String
        Dim a As String = comboBox3.Text
        Dim b As String = comboBox4.Text
        'mgl
        If a = "мг/л" And b = "ммоль/л" Then
            r = z * 0.009991
            textBox13.Text = r
            label15.Text = "ммоль/л"
        End If
        If a = "мг/л" And b = "мг-экв/л" Then
            r = z * 0.01998
            textBox13.Text = r
            label15.Text = "мг-экв/л"
        End If
        If a = "мг/л" And b = "немец. градус" Then
            r = z * 0.05603
            textBox13.Text = r
            label15.Text = "немец. градус"
        End If
        'mmoll
        If a = "ммоль/л" And b = "мг/л" Then
            r = z * 100.1
            textBox13.Text = r
            label15.Text = "мг/л"
        End If
        If a = "ммоль/л" And b = "мг-экв/л" Then
            r = z * 2
            textBox13.Text = r
            label15.Text = "мг-экв/л"
        End If
        If a = "ммоль/л" And b = "немец. градус" Then
            r = z * 5.608
            textBox13.Text = r
            label15.Text = "немец. градус"
        End If
        'mgekvl
        If a = "мг-экв/л" And b = "мг/л" Then
            r = z * 50.05
            textBox13.Text = r
            label15.Text = "мг/л"
        End If
        If a = "мг-экв/л" And b = "ммоль/л" Then
            r = z * 0.5
            textBox13.Text = r
            label15.Text = "ммоль/л"
        End If
        If a = "мг-экв/л" And b = "немец. градус" Then
            r = z * 2.804
            textBox13.Text = r
            label15.Text = "немец. градус"
        End If
        'немец
        If a = "немец. градус" And b = "ммоль/л" Then
            r = z * 0.01783
            textBox13.Text = r
            label15.Text = "ммоль/л"
        End If
        If a = "немец. градус" And b = "мг-экв/л" Then
            r = z * 0.3566
            textBox13.Text = r
            label15.Text = "мг-экв/л"
        End If
        If a = "немец. градус" And b = "мг/л" Then
            r = z * 17.85
            textBox13.Text = r
            label15.Text = "немец. градус"
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim inr As String, thr As String
        inr = My.Computer.FileSystem.ReadAllText("lang.ini")
        thr = My.Computer.FileSystem.ReadAllText("theme.ini")
        Select Case (inr)
            Case "lang=be"
                groupBox1.Text = "Кальцый, магнiй"
                groupBox2.Text = "Аміяк"
                groupBox3.Text = "Мутнасьць"
                groupBox4.Text = "Гідракарбанаты"
                label1.Text = "К-сьць кропель да зялёнага колеру"
                label2.Text = "Калянасьць (мґ-экв/л)"
                label3.Text = "Кальцый"
                label4.Text = "Mагнiй"
                label5.Text = "К-сьць кропель да жоўтага колеру"
                label6.Text = "Гiдракарбанаты (мґ/л)"
                label8.Text = "Набярыце мутнасьць у NTU"
                label9.Text = "Мутнасьць (мґ/л)"
                label10.Text = "Набярыце рН (для драбей - коска)"
                label11.Text = "Набярыце амонiй"
                label12.Text = "Аміяк"
                button1.Text = "Падлік"
                button2.Text = "Падлік"
                button3.Text = "Падлік"
                button4.Text = "Падлік"
                файлToolStripMenuItem.Text = "Файл"
                очиститьПоляToolStripMenuItem.Text = "Ачысьціць паля"
                сохранитьВФайлToolStripMenuItem1.Text = "Захаваць у файл"
                сервисToolStripMenuItem.Text = "Сэрвіс"
                дебитомерToolStripMenuItem.Text = "Дэбітамер"
                команднаяСтрокаToolStripMenuItem.Text = "Камандны радок"
                темаОформленияToolStripMenuItem.Text = "Тэма афармленьня"
                информацияToolStripMenuItem.Text = "Інфармацыя"
                оПрограммеToolStripMenuItem.Text = "Мова"
                закрытьToolStripMenuItem.Text = "Закрыць"
                ммольлToolStripMenuItem.Text = "ммоль/л"
                единицыToolStripMenuItem.Text = "Адзінкі"
                немецкийГрадусToolStripMenuItem1.Text = "Нямецкі градус"
                французскийГрадусToolStripMenuItem1.Text = "Французскі градус"
                открытьФайлАнализаToolStripMenuItem.Text = "Адкрыць файл аналіза"
                groupBox5.Text = "Канверцер адзінкаў жорсткасьці"
                label7.Text = "Адзінка 1"
                label13.Text = "Перакласьці ў: "
                label14.Text = "Рэзультат"
            Case "lang=bl"
                groupBox1.Text = "Kaľcyj, magnij"
                groupBox2.Text = "Amiäk"
                groupBox3.Text = "Mutnaść"
                groupBox4.Text = "Gidrakarbanaty"
                label1.Text = "K-ść kropläú da zälönaga koleru"
                label2.Text = "Kalänaść (mģ/ékv-l)"
                label3.Text = "Kaľcyj"
                label4.Text = "Magnij"
                label5.Text = "K-ść kropläú da žoútaga koleru"
                label6.Text = "Gidrakarbanaty (mģ/l)"
                label8.Text = "Nabäryce mutnaść u NTU"
                label9.Text = "Mutnaść (mģ/l)"
                label10.Text = "Nabäryce рН (dlä drabej - koska)"
                label11.Text = "Nabäryce amonij"
                label12.Text = "Amiäk"
                button1.Text = "Padlik"
                button2.Text = "Padlik"
                button3.Text = "Padlik"
                button4.Text = "Padlik"
                файлToolStripMenuItem.Text = "Fajl"
                очиститьПоляToolStripMenuItem.Text = "Ačyścić paľa"
                сохранитьВФайлToolStripMenuItem1.Text = "Zahavać u fajl"
                сервисToolStripMenuItem.Text = "Sérvis"
                дебитомерToolStripMenuItem.Text = "Débitamer"
                команднаяСтрокаToolStripMenuItem.Text = "Kamandny radok"
                темаОформленияToolStripMenuItem.Text = "Téma afarmleńnä"
                информацияToolStripMenuItem.Text = "Infarmacyä"
                оПрограммеToolStripMenuItem.Text = "Mova"
                закрытьToolStripMenuItem.Text = "Zakryć"
                ммольлToolStripMenuItem.Text = "mmoľ/l"
                единицыToolStripMenuItem.Text = "Aďinki"
                немецкийГрадусToolStripMenuItem1.Text = "Nämecki gradus"
                французскийГрадусToolStripMenuItem1.Text = "Francuzski gradus"
                открытьФайлАнализаToolStripMenuItem.Text = "Adkryć fajl"
                открытьФайлАнализаToolStripMenuItem.Text = "Adkryć fajl analiza"
                groupBox5.Text = "Kanvercer aďinkaú žorstkaści"
                label7.Text = "Aďinka 1:"
                label13.Text = "Peraklaści ú: "
                label14.Text = "Rézuľtat"
            Case "lang=en"
                groupBox1.Text = "Calcium, magnesium"
                groupBox2.Text = "Ammonia"
                groupBox3.Text = "Turbidity"
                groupBox4.Text = "Hydrocarbonates"
                label1.Text = "Number of drops to green color"
                label2.Text = "Water hardness (mg/equiv-l)"
                label3.Text = "Calcium"
                label4.Text = "Magnesium"
                label5.Text = "Number of drops to yellow color"
                label6.Text = "Hydrocarbonates (mg/l)"
                label8.Text = "Type turbidity in NTU"
                label9.Text = "Turbidity (mg/l)"
                label10.Text = "Type рН (for fractions - comma)"
                label11.Text = "Type ammonium"
                label12.Text = "Ammoniа"
                button1.Text = "Count"
                button2.Text = "Count"
                button3.Text = "Count"
                button4.Text = "Count"
                файлToolStripMenuItem.Text = "File"
                очиститьПоляToolStripMenuItem.Text = "Clear"
                сохранитьВФайлToolStripMenuItem1.Text = "Save to file"
                сервисToolStripMenuItem.Text = "Services"
                дебитомерToolStripMenuItem.Text = "Debitomer"
                команднаяСтрокаToolStripMenuItem.Text = "Comand line"
                темаОформленияToolStripMenuItem.Text = "Theme"
                информацияToolStripMenuItem.Text = "Information"
                оПрограммеToolStripMenuItem.Text = "Language"
                закрытьToolStripMenuItem.Text = "Close"
                ммольлToolStripMenuItem.Text = "mmol/l"
                единицыToolStripMenuItem.Text = "Units"
                мглToolStripMenuItem.Text = "mg/l"
                немецкийГрадусToolStripMenuItem1.Text = "German degree"
                французскийГрадусToolStripMenuItem1.Text = "French degree"
                открытьФайлАнализаToolStripMenuItem.Text = "Open file"
                groupBox5.Text = "Water hardness converter"
                label7.Text = "Unit 1"
                label13.Text = "Convert to: "
                label14.Text = "Result"
            Case "lang=uk"
                groupBox1.Text = "Кальцій, магній"
                groupBox2.Text = "Аміак"
                groupBox3.Text = "Мутність"
                groupBox4.Text = "Гідрокарбонати"
                label1.Text = "К-сть крапель до зеленого кольору"
                label2.Text = "Жорсткість (мг-екв/л)"
                label3.Text = "Кальцій"
                label4.Text = "Магній"
                label5.Text = "К-сть крапель до зеленого кольору"
                label6.Text = "Гідрокарбонати"
                label8.Text = "Наберите мутность в NTU"
                label9.Text = "Мутность (мг/л)"
                label10.Text = "Наберите рН (для дробів - коска)"
                label11.Text = "Наберите амоній"
                label12.Text = "Аміак"
                button1.Text = "Підрахунок"
                button2.Text = "Підрахунок"
                button3.Text = "Підрахунок"
                button4.Text = "Підрахунок"
                ммольлToolStripMenuItem.Text = "mmoль/л"
                единицыToolStripMenuItem.Text = "Одиницi"
                немецкийГрадусToolStripMenuItem1.Text = "Німецькій градус"
                французскийГрадусToolStripMenuItem1.Text = "Французській градус"
                файлToolStripMenuItem.Text = "Файл"
                очиститьПоляToolStripMenuItem.Text = "Очистити поля"
                сохранитьВФайлToolStripMenuItem1.Text = "Зберегти в файл"
                сервисToolStripMenuItem.Text = "Сервис"
                дебитомерToolStripMenuItem.Text = "Дебитомер"
                команднаяСтрокаToolStripMenuItem.Text = "Командний рядок"
                темаОформленияToolStripMenuItem.Text = "Тема оформлення"
                информацияToolStripMenuItem.Text = "Інформація"
                оПрограммеToolStripMenuItem.Text = "Мова"
                закрытьToolStripMenuItem.Text = "Закрити"
                открытьФайлАнализаToolStripMenuItem.Text = "Одкрити файл аналіза"
                groupBox5.Text = "Конвертер одиниц жорсткіcти"
                label7.Text = "Одиниця 1"
                label13.Text = "Переведено в: "
                label14.Text = "Результат"
            Case "lang=ru"
                groupBox1.Text = "Кальций, магний"
                groupBox2.Text = "Аммиак"
                groupBox3.Text = "Мутность"
                groupBox4.Text = "Гидрокарбонаты"
                label1.Text = "Кол-во капель до зеленого цвета"
                label2.Text = "Жесткость (мг-экв/л)"
                label3.Text = "Кальций"
                label4.Text = "Магний"
                label5.Text = "Кол-во капель до зеленого цвета"
                label6.Text = "Гидрокарбонаты"
                label8.Text = "Наберите мутность в NTU"
                label9.Text = "Мутность (мг/л)"
                label10.Text = "Наберите рН (для дробей - запятая)"
                label11.Text = "Наберите аммоний"
                label12.Text = "Аммиак"
                button1.Text = "Подсчет"
                button2.Text = "Подсчет"
                button3.Text = "Подсчет"
                button4.Text = "Подсчет"
                ммольлToolStripMenuItem.Text = "mmoль/л"
                единицыToolStripMenuItem.Text = "Единицы"
                немецкийГрадусToolStripMenuItem1.Text = "Немецкий градус"
                французскийГрадусToolStripMenuItem1.Text = "Французский градус"
                файлToolStripMenuItem.Text = "Файл"
                очиститьПоляToolStripMenuItem.Text = "Очистить поля"
                сохранитьВФайлToolStripMenuItem1.Text = "Сохранить в файл"
                сервисToolStripMenuItem.Text = "Сервисы"
                дебитомерToolStripMenuItem.Text = "Дебитомер"
                команднаяСтрокаToolStripMenuItem.Text = "Командная строка"
                темаОформленияToolStripMenuItem.Text = "Темы оформления"
                информацияToolStripMenuItem.Text = "Информация"
                оПрограммеToolStripMenuItem.Text = "Язык"
                закрытьToolStripMenuItem.Text = "Закрыть"
                открытьФайлАнализаToolStripMenuItem.Text = "Открыть файл анализа"
                groupBox5.Text = "Конвертер единиц жесткости"
                label7.Text = "Единица 1"
                label13.Text = "Перевести в: "
                label14.Text = "Результат"
        End Select
        Select Case (thr)
            Case "theme=std"
                menuStrip1.RenderMode = Windows.Forms.ToolStripRenderMode.System
            Case "theme=xp"
                menuStrip1.RenderMode = Windows.Forms.ToolStripRenderMode.Professional
        End Select
    End Sub
End Class
