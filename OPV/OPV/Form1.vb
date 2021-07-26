
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
        Timer2.Start()
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
        Timer2.Start()
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
        Timer2.Start()
    End Sub

    Private Sub французскийГрадусToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles французскийГрадусToolStripMenuItem1.Click
        Dim a As String, b As String
        a = textBox1.Text
        b = a * 1.785
        textBox2.Text = b
        label2.Text = "Жесткость (фр. гр.)"
        Timer2.Start()
    End Sub

    Private Sub ммольлToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ммольлToolStripMenuItem.Click
        Dim a As String, b As String
        a = textBox1.Text
        b = a * 0.1783
        textBox2.Text = b
        label2.Text = "Жесткость (ммоль/л)"
        Timer2.Start()
    End Sub

    Private Sub мглToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles мглToolStripMenuItem.Click
        Dim a As String, b As String
        a = textBox1.Text
        b = a * 17.85
        textBox2.Text = b
        label2.Text = "Жесткость (мг/л)"
        Timer2.Start()
    End Sub

    Private Sub дебитомерToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles дебитомерToolStripMenuItem.Click
        Timer2.Start()
        Shell("dm.exe", vbNormalFocus)
    End Sub

    Private Sub команднаяСтрокаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles команднаяСтрокаToolStripMenuItem.Click
        Shell("cmd", vbNormalFocus)
    End Sub

    Private Sub стандартнаяToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles стандартнаяToolStripMenuItem.Click
        menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        My.Computer.FileSystem.DeleteFile("theme.ini")
        My.Computer.FileSystem.WriteAllText("theme.ini", "theme=std", True)
        Timer2.Start()
    End Sub

    Private Sub windowsXPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles windowsXPToolStripMenuItem.Click
        menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        My.Computer.FileSystem.DeleteFile("theme.ini")
        My.Computer.FileSystem.WriteAllText("theme.ini", "theme=xp", True)
        Timer2.Start()
    End Sub

    Private Sub пакетОбновленияToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("CScript sp.vbs", vbNormalFocus)
    End Sub

    Private Sub информацияToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles информацияToolStripMenuItem.Click
        Shell("info.exe", vbNormalFocus)
    End Sub

    Private Sub беларускаяМоваToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles беларускаяМоваToolStripMenuItem1.Click
        СтеретьФайлАнализаToolStripMenuItem.Text = "Сьцерці файл аналізу"
        RadioButton1.Text = "Каалін"
        RadioButton2.Text = "Крамнязём (дыятаміт)"
        стандартнаяToolStripMenuItem.Text = "Стандартная"
        groupBox1.Text = "Кальцый, магнiй"
        groupBox2.Text = "Аміяк"
        groupBox3.Text = "Мутнасьць"
        groupBox4.Text = "Гідракарбанаты"
        GroupBox6.Text = "Раствораны кісларод у вадзе"
        Label17.Text = "Тэмпература, С"
        Button6.Text = "Падлік"
        LinkLabel1.Text = "Інфармацыя"
        LinkLabel2.Text = "Інфармацыя"
        Label18.Text = "Кісларод, мг/л"
        label1.Text = "К-сьць кропель да зялёнага колеру"
        label2.Text = "Калянасьць (мг-экв/л)"
        label3.Text = "Кальцый"
        label4.Text = "Mагнiй"
        label5.Text = "К-сьць кропель да жоўтага колеру"
        label6.Text = "Гiдракарбанаты (мг/л)"
        label8.Text = "Набярыце мутнасьць у NTU"
        label9.Text = "Мутнасьць (мг/л)"
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
        ToolStripStatusLabel1.Text = "Status  "
        СтеретьФайлАнализаToolStripMenuItem.Text = "Ścerci fajl analizu"
        RadioButton1.Text = "Kaalin"
        RadioButton2.Text = "Kramnjazjom (dijatamit)"
        стандартнаяToolStripMenuItem.Text = "Standartna"
        GroupBox6.Text = "Rastvorany kiseń u vađe"
        Label17.Text = "Temperatura, C"
        Button6.Text = "Padlik"
        LinkLabel1.Text = "Infarmacyja"
        LinkLabel2.Text = "Infarmacyja"
        Label18.Text = "Kiseń, mg/l"
        groupBox1.Text = "Kaljcyj, magnij"
        groupBox2.Text = "Amijak"
        groupBox3.Text = "Mutnaść"
        groupBox4.Text = "Gidrakarbanati"
        label1.Text = "K-ść kropljaú da zjaljonaga koleru"
        label2.Text = "Kaljanaść (mg/ekv-l)"
        label3.Text = "Kaljcyj"
        label4.Text = "Magnij"
        label5.Text = "K-ść kropljaú da žoútaga koleru"
        label6.Text = "Gidrakarbanati (mģ/l)"
        label8.Text = "Nabjarice mutnaść u NTU"
        label9.Text = "Mutnaść (mģ/l)"
        label10.Text = "Nabjaryce рН (dlja drabej - koska)"
        label11.Text = "Nabjaryce amonij"
        label12.Text = "Amijak"
        button1.Text = "Padlik"
        button2.Text = "Padlik"
        button3.Text = "Padlik"
        button4.Text = "Padlik"
        ммольлToolStripMenuItem.Text = "mmolj/l"
        единицыToolStripMenuItem.Text = "Ađinki"
        немецкийГрадусToolStripMenuItem1.Text = "Njamecki gradus"
        французскийГрадусToolStripMenuItem1.Text = "Francuzski gradus"
        файлToolStripMenuItem.Text = "Fajl"
        очиститьПоляToolStripMenuItem.Text = "Ačiścić palja"
        сохранитьВФайлToolStripMenuItem1.Text = "Zahavać u fajl"
        сервисToolStripMenuItem.Text = "Servis"
        дебитомерToolStripMenuItem.Text = "Debitamer"
        команднаяСтрокаToolStripMenuItem.Text = "Kamandny radok"
        темаОформленияToolStripMenuItem.Text = "Tema afarmleńnja"
        информацияToolStripMenuItem.Text = "Infarmacyja"
        оПрограммеToolStripMenuItem.Text = "Mova"
        закрытьToolStripMenuItem.Text = "Zakrić"
        открытьФайлАнализаToolStripMenuItem.Text = "Adkrić fajl analiza"
        groupBox5.Text = "Kanvertër ađinkaú žorstkaści"
        label7.Text = "Ađinka 1:"
        label13.Text = "Peraklaści ú: "
        label14.Text = "Rezuljtat"
        My.Computer.FileSystem.DeleteFile("lang.ini")
        My.Computer.FileSystem.WriteAllText("lang.ini", "lang=bl", True)
    End Sub

    Private Sub українськаМоваToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles українськаМоваToolStripMenuItem.Click
        СтеретьФайлАнализаToolStripMenuItem.Text = "Стерти файл аналізу"
        RadioButton1.Text = "Каолін"
        RadioButton2.Text = "Кремнезем (діятоміт)"
        стандартнаяToolStripMenuItem.Text = "Стандартная"
        groupBox1.Text = "Кальцій, магній"
        groupBox2.Text = "Аміак"
        groupBox3.Text = "Мутність"
        groupBox4.Text = "Гідрокарбонати"
        GroupBox6.Text = "Розчинений кисень у воді"
        Label17.Text = "Температура, С"
        Button6.Text = "Підрахунок"
        LinkLabel1.Text = "Інформація"
        LinkLabel2.Text = "Інформація"
        Label18.Text = "Кисень, мг/л"
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
        ToolStripStatusLabel1.Text = "Status  "
        СтеретьФайлАнализаToolStripMenuItem.Text = "Erase analysis file"
        RadioButton1.Text = "Kaolin"
        RadioButton2.Text = "Silica (diatomite)"
        стандартнаяToolStripMenuItem.Text = "Standart theme"
        groupBox1.Text = "Calcium, magnesium"
        groupBox2.Text = "Ammonia"
        groupBox3.Text = "Turbidity"
        groupBox4.Text = "Hydrocarbonates"
        GroupBox6.Text = "Dissolved oxygen in water"
        Label17.Text = "Тemperature, С"
        Button6.Text = "Count"
        LinkLabel1.Text = "Info"
        LinkLabel2.Text = "Info"
        Label18.Text = "Oxygen, mg/l"
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
        СтеретьФайлАнализаToolStripMenuItem.Text = "Стереть файл анализа"
        RadioButton1.Text = "Каолин"
        RadioButton2.Text = "Кремнезем (диатомит)"
        стандартнаяToolStripMenuItem.Text = "Стандартная"
        groupBox1.Text = "Кальций, магний"
        groupBox2.Text = "Аммиак"
        groupBox3.Text = "Мутность"
        groupBox4.Text = "Гидрокарбонаты"
        GroupBox6.Text = "Растворенный кислород в воде"
        Label17.Text = "Температура, С"
        Button6.Text = "Подсчет"
        LinkLabel1.Text = "Информация"
        LinkLabel2.Text = "Информация"
        Label18.Text = "Кислород, мг/л"
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
                RadioButton1.Text = "Каалін"
                RadioButton2.Text = "Крамнязём (дыятаміт)"
                стандартнаяToolStripMenuItem.Text = "Стандартная"
                GroupBox6.Text = "Раствораны кісларод у вадзе"
                Label17.Text = "Тэмпература, С"
                Button6.Text = "Падлік"
                LinkLabel1.Text = "Інфармацыя"
                LinkLabel2.Text = "Інфармацыя"
                Label18.Text = "Кісларод, мг/л"
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
                ToolStripStatusLabel1.Text = "Status  "
                СтеретьФайлАнализаToolStripMenuItem.Text = "Ścerci fajl analizu"
                RadioButton1.Text = "Kaalin"
                RadioButton2.Text = "Kramnjazjom (dijatamit)"
                стандартнаяToolStripMenuItem.Text = "Standartna"
                GroupBox6.Text = "Rastvorany kiseń u vađe"
                Label17.Text = "Temperatura, C"
                Button6.Text = "Padlik"
                LinkLabel1.Text = "Infarmacyja"
                LinkLabel2.Text = "Infarmacyja"
                Label18.Text = "Kiseń, mg/l"
                groupBox1.Text = "Kaljcyj, magnij"
                groupBox2.Text = "Amijak"
                groupBox3.Text = "Mutnaść"
                groupBox4.Text = "Gidrakarbanati"
                label1.Text = "K-ść kropljaú da zjaljonaga koleru"
                label2.Text = "Kaljanaść (mg/ekv-l)"
                label3.Text = "Kaljcyj"
                label4.Text = "Magnij"
                label5.Text = "K-ść kropljaú da žoútaga koleru"
                label6.Text = "Gidrakarbanati (mģ/l)"
                label8.Text = "Nabjarice mutnaść u NTU"
                label9.Text = "Mutnaść (mģ/l)"
                label10.Text = "Nabjaryce рН (dlja drabej - koska)"
                label11.Text = "Nabjaryce amonij"
                label12.Text = "Amijak"
                button1.Text = "Padlik"
                button2.Text = "Padlik"
                button3.Text = "Padlik"
                button4.Text = "Padlik"
                ммольлToolStripMenuItem.Text = "mmolj/l"
                единицыToolStripMenuItem.Text = "Ađinki"
                немецкийГрадусToolStripMenuItem1.Text = "Njamecki gradus"
                французскийГрадусToolStripMenuItem1.Text = "Francuzski gradus"
                файлToolStripMenuItem.Text = "Fajl"
                очиститьПоляToolStripMenuItem.Text = "Ačiścić palja"
                сохранитьВФайлToolStripMenuItem1.Text = "Zahavać u fajl"
                сервисToolStripMenuItem.Text = "Servis"
                дебитомерToolStripMenuItem.Text = "Debitamer"
                команднаяСтрокаToolStripMenuItem.Text = "Kamandny radok"
                темаОформленияToolStripMenuItem.Text = "Tema afarmleńnja"
                информацияToolStripMenuItem.Text = "Infarmacyja"
                оПрограммеToolStripMenuItem.Text = "Mova"
                закрытьToolStripMenuItem.Text = "Zakrić"
                открытьФайлАнализаToolStripMenuItem.Text = "Adkrić fajl analiza"
                groupBox5.Text = "Kanvertër ađinkaú žorstkaści"
                label7.Text = "Ađinka 1:"
                label13.Text = "Peraklaści ú: "
                label14.Text = "Rezuljtat"
            Case "lang=en"
                ToolStripStatusLabel1.Text = "Status  "
                СтеретьФайлАнализаToolStripMenuItem.Text = "Erase analysis file"
                RadioButton1.Text = "Kaolin"
                RadioButton2.Text = "Silica (diatomite)"
                стандартнаяToolStripMenuItem.Text = "Standard theme"
                GroupBox6.Text = "Dissolved oxygen in water"
                Label17.Text = "Тemperature, С"
                Button6.Text = "Count"
                LinkLabel1.Text = "Info"
                LinkLabel2.Text = "Info"
                Label18.Text = "Oxygen, mg/l"
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
                СтеретьФайлАнализаToolStripMenuItem.Text = "Стерти файл аналізу"
                RadioButton1.Text = "Каолін"
                RadioButton2.Text = "Кремнезем (діятоміт)"
                стандартнаяToolStripMenuItem.Text = "Стандартна"
                GroupBox6.Text = "Розчинений кисень у воді"
                Label17.Text = "Температура, С"
                Button6.Text = "Підрахунок"
                LinkLabel1.Text = "Інформація"
                LinkLabel2.Text = "Інформація"
                Label18.Text = "Кисень, мг/л"
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
                СтеретьФайлАнализаToolStripMenuItem.Text = "Стереть файл анализа"
                RadioButton1.Text = "Каолин"
                RadioButton2.Text = "Кремнезем (диатомит)"
                стандартнаяToolStripMenuItem.Text = "Стандартная"
                GroupBox6.Text = "Растворенный кислород в воде"
                Label17.Text = "Температура, С"
                Button6.Text = "Подсчет"
                LinkLabel1.Text = "Информация"
                LinkLabel2.Text = "Информация"
                Label18.Text = "Кислород, мг/л"
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

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If NumericUpDown1.Value = 0 Then
            TextBox16.Text = "14,6"
        End If
        If NumericUpDown1.Value = 1 Then
            TextBox16.Text = "14,2"
        End If
        If NumericUpDown1.Value = 2 Then
            TextBox16.Text = "13,8"
        End If
        If NumericUpDown1.Value = 3 Then
            TextBox16.Text = "13,3"
        End If
        If NumericUpDown1.Value = 4 Then
            TextBox16.Text = "13,0"
        End If
        If NumericUpDown1.Value = 5 Then
            TextBox16.Text = "12,6"
        End If
        If NumericUpDown1.Value = 6 Then
            TextBox16.Text = "12,3"
        End If
        If NumericUpDown1.Value = 7 Then
            TextBox16.Text = "12,0"
        End If
        If NumericUpDown1.Value = 8 Then
            TextBox16.Text = "11,7"
        End If
        If NumericUpDown1.Value = 9 Then
            TextBox16.Text = "11,4"
        End If
        If NumericUpDown1.Value = 10 Then
            TextBox16.Text = "11,2"
        End If
        If NumericUpDown1.Value = 11 Then
            TextBox16.Text = "10,9"
        End If
        If NumericUpDown1.Value = 12 Then
            TextBox16.Text = "10,7"
        End If
        If NumericUpDown1.Value = 13 Then
            TextBox16.Text = "10,4"
        End If
    End Sub

    Private Sub СтеретьФайлАнализаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СтеретьФайлАнализаToolStripMenuItem.Click
        Dim fp As String = "analiz.txt"
        My.Computer.FileSystem.DeleteFile(fp)
        My.Computer.FileSystem.WriteAllText(fp, "", True)
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ToolStripProgressBar1.Increment(1)
        If ToolStripProgressBar1.Value = 100 Then
            Timer2.Stop()
            ToolStripProgressBar1.Value = 0
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim zNO3 As String = TextBox20.Text, dNO3 As String = 45, iNO3 As String = System.Math.Round(zNO3 / dNO3, 3)
        Dim zNO2 As String = TextBox22.Text, dNO2 As String = 3, iNO2 As String = System.Math.Round(zNO2 / dNO2, 3)
        Dim zZS As String = TextBox19.Text, dZS As String = 7, iZS As String = System.Math.Round(zZS / dZS, 3)
        Dim zPO4 As String = TextBox21.Text, dPO4 As String = 3.5, iPO4 As String = System.Math.Round(zPO4 / dPO4, 3)
        Dim zFe As String = TextBox23.Text, dFe As String = 0.3, iFe As String = System.Math.Round(zFe / dFe, 3)
        Dim zCu As String = TextBox24.Text, dCu As String = 1, iCu As String = System.Math.Round(zCu / dCu, 3)
        Dim zNH3 As String = TextBox26.Text, dNH3 As String = 0.18, iNH3 As String = System.Math.Round(zNH3 / dNH3, 3)
        Dim zNH4 As String = TextBox26.Text, dNH4 As String = 0.18, iNH4 As String = System.Math.Round(zNH4 / dNH4, 3)
        Dim sum As Double = System.Convert.ToDouble(iNO3) + System.Convert.ToDouble(iNO2) + System.Convert.ToDouble(iZS) + System.Convert.ToDouble(iPO4) + System.Convert.ToDouble(iFe) + System.Convert.ToDouble(iCu) + System.Convert.ToDouble(iNH3) + System.Convert.ToDouble(iNH4)
        MsgBox(sum)
        Dim izv = sum / 8
        TextBox27.Text = System.Convert.ToString(izv)
        If izv < 0.2 Then
            TextBox18.Text = "Очень чистая"
            TextBox18.BackColor = System.Drawing.Color.LimeGreen
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim k As Double = System.Convert.ToDouble(TextBox28.Text) * 0.0001
        Dim d As Double = System.Convert.ToDouble(ComboBox5.Text) ^ 2
        Dim s As String = System.Convert.ToDecimal(0.785 * d / 1000000)
        Dim l As Double = System.Convert.ToDouble(ComboBox6.Text) * 0.01 'm
        Dim ks As String = System.Convert.ToDecimal(k * s)
        Dim R As Double = System.Math.Round(l / ks, 1)
        TextBox30.Text = System.Convert.ToString(R)
    End Sub
End Class