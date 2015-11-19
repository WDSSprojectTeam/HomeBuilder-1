
Partial Class FeatureEvaluation1
    Inherits System.Web.UI.Page

    Private myFeatureList As New List(Of Feature)

    'FLOORS

    Protected Sub cbxCarpet_CheckedChanged(sender As Object, e As EventArgs) Handles cbxCarpet.CheckedChanged, cbxTile.CheckedChanged, cbxHardwood.CheckedChanged, cbxTileShingle.CheckedChanged
        If cbxCarpet.Checked = False Then
            pnlCarpet.Enabled = True
            pnlTile.Enabled = True
            pnlHardwood.Enabled = True
            pnlTileShingle.Enabled = True
            rltCarpet.Enabled = True
            rltTile.Enabled = True
            rltHardwood.Enabled = True
            rltTileShingle.Enabled = True
        ElseIf cbxTile.Checked = False Then
            pnlCarpet.Enabled = True
            pnlTile.Enabled = True
            pnlHardwood.Enabled = True
            pnlTileShingle.Enabled = True
            rltCarpet.Enabled = True
            rltTile.Enabled = True
            rltHardwood.Enabled = True
            rltTileShingle.Enabled = True
        ElseIf cbxHardwood.Checked = False Then
            pnlCarpet.Enabled = True
            pnlTile.Enabled = True
            pnlHardwood.Enabled = True
            pnlTileShingle.Enabled = True
            rltCarpet.Enabled = True
            rltTile.Enabled = True
            rltHardwood.Enabled = True
            rltTileShingle.Enabled = True
        ElseIf cbxTileShingle.Checked = False Then
            pnlCarpet.Enabled = True
            pnlTile.Enabled = True
            pnlHardwood.Enabled = True
            pnlTileShingle.Enabled = True
            rltCarpet.Enabled = True
            rltTile.Enabled = True
            rltHardwood.Enabled = True
            rltTileShingle.Enabled = True
        End If

        If cbxCarpet.Checked = True Then
            pnlTile.Enabled = False
            pnlHardwood.Enabled = False
            pnlTileShingle.Enabled = False
            rltCarpet.Enabled = False
            rltCarpet.ClearSelection()
            rltTile.ClearSelection()
            rltHardwood.ClearSelection()
            rltTileShingle.ClearSelection()
        ElseIf cbxTile.Checked = True Then
            pnlCarpet.Enabled = False
            pnlHardwood.Enabled = False
            pnlTileShingle.Enabled = False
            rltTile.Enabled = False
            rltCarpet.ClearSelection()
            rltTile.ClearSelection()
            rltHardwood.ClearSelection()
            rltTileShingle.ClearSelection()
        ElseIf cbxHardwood.Checked = True Then
            pnlCarpet.Enabled = False
            pnlTile.Enabled = False
            pnlTileShingle.Enabled = False
            rltHardwood.Enabled = False
            rltCarpet.ClearSelection()
            rltTile.ClearSelection()
            rltHardwood.ClearSelection()
            rltTileShingle.ClearSelection()
        ElseIf cbxTileShingle.Checked = True Then
            pnlCarpet.Enabled = False
            pnlTile.Enabled = False
            pnlHardwood.Enabled = False
            rltTileShingle.Enabled = False
            rltCarpet.ClearSelection()
            rltTile.ClearSelection()
            rltHardwood.ClearSelection()
            rltTileShingle.ClearSelection()
        End If
    End Sub

    'ROOF TYPE

    Protected Sub cbxAsphaltShingle_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAsphaltShingle.CheckedChanged, cbxWoodShingle.CheckedChanged, cbxMetalShingle.CheckedChanged, cbxSlateShingle.CheckedChanged
        If cbxAsphaltShingle.Checked = False Then
            pnlAsphaltShingle.Enabled = True
            pnlWoodShingle.Enabled = True
            pnlMetalShingle.Enabled = True
            pnlSlateShingle.Enabled = True
            rltAsphaltShingle.Enabled = True
            rltWoodShingle.Enabled = True
            rltMetalShingle.Enabled = True
            rltSlateShingle.Enabled = True
        ElseIf cbxWoodShingle.Checked = False Then
            pnlAsphaltShingle.Enabled = True
            pnlWoodShingle.Enabled = True
            pnlMetalShingle.Enabled = True
            pnlSlateShingle.Enabled = True
            rltAsphaltShingle.Enabled = True
            rltWoodShingle.Enabled = True
            rltMetalShingle.Enabled = True
            rltSlateShingle.Enabled = True
        ElseIf cbxMetalShingle.Checked = False Then
            pnlAsphaltShingle.Enabled = True
            pnlWoodShingle.Enabled = True
            pnlMetalShingle.Enabled = True
            pnlSlateShingle.Enabled = True
            rltAsphaltShingle.Enabled = True
            rltWoodShingle.Enabled = True
            rltMetalShingle.Enabled = True
            rltSlateShingle.Enabled = True
        ElseIf cbxSlateShingle.Checked = False Then
            pnlAsphaltShingle.Enabled = True
            pnlWoodShingle.Enabled = True
            pnlMetalShingle.Enabled = True
            pnlSlateShingle.Enabled = True
            rltAsphaltShingle.Enabled = True
            rltWoodShingle.Enabled = True
            rltMetalShingle.Enabled = True
            rltSlateShingle.Enabled = True
        End If

        If cbxAsphaltShingle.Checked = True Then
            pnlWoodShingle.Enabled = False
            pnlMetalShingle.Enabled = False
            pnlSlateShingle.Enabled = False
            rltAsphaltShingle.Enabled = False
            rltAsphaltShingle.ClearSelection()
            rltWoodShingle.ClearSelection()
            rltMetalShingle.ClearSelection()
            rltSlateShingle.ClearSelection()
        ElseIf cbxWoodShingle.Checked = True Then
            pnlAsphaltShingle.Enabled = False
            pnlSlateShingle.Enabled = False
            pnlMetalShingle.Enabled = False
            rltWoodShingle.Enabled = False
            rltAsphaltShingle.ClearSelection()
            rltWoodShingle.ClearSelection()
            rltMetalShingle.ClearSelection()
            rltSlateShingle.ClearSelection()
        ElseIf cbxMetalShingle.Checked = True Then
            pnlAsphaltShingle.Enabled = False
            pnlWoodShingle.Enabled = False
            pnlSlateShingle.Enabled = False
            rltMetalShingle.Enabled = False
            rltAsphaltShingle.ClearSelection()
            rltWoodShingle.ClearSelection()
            rltMetalShingle.ClearSelection()
            rltSlateShingle.ClearSelection()
        ElseIf cbxSlateShingle.Checked = True Then
            pnlAsphaltShingle.Enabled = False
            pnlWoodShingle.Enabled = False
            pnlMetalShingle.Enabled = False
            rltSlateShingle.Enabled = False
            rltAsphaltShingle.ClearSelection()
            rltWoodShingle.ClearSelection()
            rltMetalShingle.ClearSelection()
            rltSlateShingle.ClearSelection()
        End If
    End Sub

    'APPLIANCES

    Protected Sub cbxStandardBeige_CheckedChanged(sender As Object, e As EventArgs) Handles cbxStandardBeige.CheckedChanged, cbxBlack.CheckedChanged, cbxStainlessSteel.CheckedChanged, cbxProfessional.CheckedChanged

        If cbxStandardBeige.Checked = False Then
            pnlStandardBeige.Enabled = True
            pnlBlack.Enabled = True
            pnlStainlessSteel.Enabled = True
            pnlProfessional.Enabled = True
            rltStandardBeige.Enabled = True
            rltBlack.Enabled = True
            rltStainlessSteel.Enabled = True
            rltProfessional.Enabled = True
        ElseIf cbxBlack.Checked = False Then
            pnlStandardBeige.Enabled = True
            pnlBlack.Enabled = True
            pnlStainlessSteel.Enabled = True
            pnlProfessional.Enabled = True
            rltStandardBeige.Enabled = True
            rltBlack.Enabled = True
            rltStainlessSteel.Enabled = True
            rltProfessional.Enabled = True
        ElseIf cbxStainlessSteel.Checked = False Then
            pnlStandardBeige.Enabled = True
            pnlBlack.Enabled = True
            pnlStainlessSteel.Enabled = True
            pnlProfessional.Enabled = True
            rltStandardBeige.Enabled = True
            rltBlack.Enabled = True
            rltStainlessSteel.Enabled = True
            rltProfessional.Enabled = True
        ElseIf cbxProfessional.Checked = False Then
            pnlStandardBeige.Enabled = True
            pnlBlack.Enabled = True
            pnlStainlessSteel.Enabled = True
            pnlProfessional.Enabled = True
            rltStandardBeige.Enabled = True
            rltBlack.Enabled = True
            rltStainlessSteel.Enabled = True
            rltProfessional.Enabled = True
        End If

        If cbxStandardBeige.Checked = True Then
            pnlProfessional.Enabled = False
            pnlBlack.Enabled = False
            pnlStainlessSteel.Enabled = False
            rltStandardBeige.Enabled = False
            rltStandardBeige.ClearSelection()
            rltBlack.ClearSelection()
            rltStainlessSteel.ClearSelection()
            rltProfessional.ClearSelection()
        ElseIf cbxBlack.Checked = True Then
            pnlProfessional.Enabled = False
            pnlStandardBeige.Enabled = False
            pnlStainlessSteel.Enabled = False
            rltBlack.Enabled = False
            rltStandardBeige.ClearSelection()
            rltBlack.ClearSelection()
            rltStainlessSteel.ClearSelection()
            rltProfessional.ClearSelection()
        ElseIf cbxStainlessSteel.Checked = True Then
            pnlProfessional.Enabled = False
            pnlBlack.Enabled = False
            pnlStandardBeige.Enabled = False
            rltStainlessSteel.Enabled = False
            rltStandardBeige.ClearSelection()
            rltBlack.ClearSelection()
            rltStainlessSteel.ClearSelection()
            rltProfessional.ClearSelection()
        ElseIf cbxProfessional.Checked = True Then
            pnlStandardBeige.Enabled = False
            pnlBlack.Enabled = False
            pnlStainlessSteel.Enabled = False
            rltProfessional.Enabled = False
            rltStandardBeige.ClearSelection()
            rltBlack.ClearSelection()
            rltStainlessSteel.ClearSelection()
            rltProfessional.ClearSelection()
        End If
    End Sub

    'GARAGE

    Protected Sub cbxOneCar_CheckedChanged(sender As Object, e As EventArgs) Handles cbxOneCar.CheckedChanged, cbxTwoCar.CheckedChanged, cbxThreeCar.CheckedChanged

        If cbxOneCar.Checked = False Then
            pnlOneCar.Enabled = True
            pnlTwoCar.Enabled = True
            pnlThreeCar.Enabled = True
            rltOneCar.Enabled = True
            rltTwoCar.Enabled = True
            rltThreeCar.Enabled = True
        ElseIf cbxTwoCar.Checked = False Then
            pnlOneCar.Enabled = True
            pnlTwoCar.Enabled = True
            pnlThreeCar.Enabled = True
            rltOneCar.Enabled = True
            rltTwoCar.Enabled = True
            rltThreeCar.Enabled = True
        ElseIf cbxThreeCar.Checked = False Then
            pnlOneCar.Enabled = True
            pnlTwoCar.Enabled = True
            pnlThreeCar.Enabled = True
            rltOneCar.Enabled = True
            rltTwoCar.Enabled = True
            rltThreeCar.Enabled = True
        End If

        If cbxOneCar.Checked = True Then
            pnlTwoCar.Enabled = False
            pnlThreeCar.Enabled = False
            rltOneCar.Enabled = False
            rltOneCar.ClearSelection()
            rltTwoCar.ClearSelection()
            rltThreeCar.ClearSelection()
        ElseIf cbxTwoCar.Checked = True Then
            pnlOneCar.Enabled = False
            pnlThreeCar.Enabled = False
            rltTwoCar.Enabled = False
            rltOneCar.ClearSelection()
            rltTwoCar.ClearSelection()
            rltThreeCar.ClearSelection()
        ElseIf cbxThreeCar.Checked = True Then
            pnlTwoCar.Enabled = False
            pnlOneCar.Enabled = False
            rltThreeCar.Enabled = False
            rltOneCar.ClearSelection()
            rltTwoCar.ClearSelection()
            rltThreeCar.ClearSelection()
        End If

    End Sub

    'COUNTERTOPS

    Protected Sub cbxGranite_CheckedChanged(sender As Object, e As EventArgs) Handles cbxGranite.CheckedChanged, cbxQuartz.CheckedChanged, cbxLaminate.CheckedChanged, cbxMarble.CheckedChanged, cbxWood.CheckedChanged

        If cbxQuartz.Checked = False Then
            pnlQuartz.Enabled = True
            PanelGranite.Enabled = True
            PanelLaminate.Enabled = True
            PanelMarble.Enabled = True
            PanelWood.Enabled = True
            rltQuartz.Enabled = True
            rltGranite.Enabled = True
            rltLaminate.Enabled = True
            rltMarble.Enabled = True
            rltWood.Enabled = True
        ElseIf cbxGranite.Checked = False Then
            pnlQuartz.Enabled = True
            PanelGranite.Enabled = True
            PanelLaminate.Enabled = True
            PanelMarble.Enabled = True
            PanelWood.Enabled = True
            rltQuartz.Enabled = True
            rltGranite.Enabled = True
            rltLaminate.Enabled = True
            rltMarble.Enabled = True
            rltWood.Enabled = True
        ElseIf cbxLaminate.Checked = False Then
            pnlQuartz.Enabled = True
            PanelGranite.Enabled = True
            PanelLaminate.Enabled = True
            PanelMarble.Enabled = True
            PanelWood.Enabled = True
            rltQuartz.Enabled = True
            rltGranite.Enabled = True
            rltLaminate.Enabled = True
            rltMarble.Enabled = True
            rltWood.Enabled = True
        ElseIf cbxMarble.Checked = False Then
            pnlQuartz.Enabled = True
            PanelGranite.Enabled = True
            PanelLaminate.Enabled = True
            PanelMarble.Enabled = True
            PanelWood.Enabled = True
            rltQuartz.Enabled = True
            rltGranite.Enabled = True
            rltLaminate.Enabled = True
            rltMarble.Enabled = True
            rltWood.Enabled = True
        ElseIf cbxWood.Checked = False Then
            pnlQuartz.Enabled = True
            PanelGranite.Enabled = True
            PanelLaminate.Enabled = True
            PanelMarble.Enabled = True
            PanelWood.Enabled = True
            rltQuartz.Enabled = True
            rltGranite.Enabled = True
            rltLaminate.Enabled = True
            rltMarble.Enabled = True
            rltWood.Enabled = True
        End If

        If cbxQuartz.Checked = True Then
            PanelGranite.Enabled = False
            PanelLaminate.Enabled = False
            PanelMarble.Enabled = False
            PanelWood.Enabled = False
            rltQuartz.Enabled = False
            rltQuartz.ClearSelection()
            rltGranite.ClearSelection()
            rltLaminate.ClearSelection()
            rltMarble.ClearSelection()
            rltWood.ClearSelection()
        ElseIf cbxGranite.Checked = True Then
            pnlQuartz.Enabled = False
            PanelLaminate.Enabled = False
            PanelMarble.Enabled = False
            PanelWood.Enabled = False
            rltGranite.Enabled = False
            rltQuartz.ClearSelection()
            rltGranite.ClearSelection()
            rltLaminate.ClearSelection()
            rltMarble.ClearSelection()
            rltWood.ClearSelection()
        ElseIf cbxLaminate.Checked = True Then
            pnlQuartz.Enabled = False
            PanelGranite.Enabled = False
            PanelMarble.Enabled = False
            PanelWood.Enabled = False
            rltLaminate.Enabled = False
            rltQuartz.ClearSelection()
            rltGranite.ClearSelection()
            rltLaminate.ClearSelection()
            rltMarble.ClearSelection()
            rltWood.ClearSelection()
        ElseIf cbxMarble.Checked = True Then
            pnlQuartz.Enabled = False
            PanelLaminate.Enabled = False
            PanelGranite.Enabled = False
            PanelWood.Enabled = False
            rltMarble.Enabled = False
            rltQuartz.ClearSelection()
            rltGranite.ClearSelection()
            rltLaminate.ClearSelection()
            rltMarble.ClearSelection()
            rltWood.ClearSelection()
        ElseIf cbxWood.Checked = True Then
            pnlQuartz.Enabled = False
            PanelLaminate.Enabled = False
            PanelMarble.Enabled = False
            PanelGranite.Enabled = False
            rltWood.Enabled = False
            rltQuartz.ClearSelection()
            rltGranite.ClearSelection()
            rltLaminate.ClearSelection()
            rltMarble.ClearSelection()
            rltWood.ClearSelection()
        End If
    End Sub

    'BATH

    Protected Sub cbxBathShower_CheckedChanged(sender As Object, e As EventArgs) Handles cbxBathShower.CheckedChanged, cbxWalkinShower.CheckedChanged, cbxRainfall.CheckedChanged
        If cbxBathShower.Checked = False Then
            pnlBathShower.Enabled = True
            pnlWalkinShower.Enabled = True
            pnlRainfall.Enabled = True
            rltBathShower.Enabled = True
            rltWalkinShower.Enabled = True
            rltRainfall.Enabled = True
        ElseIf cbxWalkinShower.Checked = False Then
            pnlBathShower.Enabled = True
            pnlWalkinShower.Enabled = True
            pnlRainfall.Enabled = True
            rltBathShower.Enabled = True
            rltWalkinShower.Enabled = True
            rltRainfall.Enabled = True
        ElseIf cbxRainfall.Checked = False Then
            pnlBathShower.Enabled = True
            pnlWalkinShower.Enabled = True
            pnlRainfall.Enabled = True
            rltBathShower.Enabled = True
            rltWalkinShower.Enabled = True
            rltRainfall.Enabled = True
        End If

        If cbxBathShower.Checked = True Then
            pnlWalkinShower.Enabled = False
            pnlRainfall.Enabled = False
            rltBathShower.Enabled = False
            rltBathShower.ClearSelection()
            rltWalkinShower.ClearSelection()
            rltRainfall.ClearSelection()
        ElseIf cbxWalkinShower.Checked = True Then
            pnlBathShower.Enabled = False
            pnlRainfall.Enabled = False
            rltWalkinShower.Enabled = False
            rltBathShower.ClearSelection()
            rltWalkinShower.ClearSelection()
            rltRainfall.ClearSelection()
        ElseIf cbxRainfall.Checked = True Then
            pnlWalkinShower.Enabled = False
            pnlBathShower.Enabled = False
            rltRainfall.Enabled = False
            rltBathShower.ClearSelection()
            rltWalkinShower.ClearSelection()
            rltRainfall.ClearSelection()
        End If

    End Sub

    'CLOSETS

    Protected Sub cbxWardrobe_CheckedChanged(sender As Object, e As EventArgs) Handles cbxWardrobe.CheckedChanged, cbxWalkinCloset.CheckedChanged
        If cbxWardrobe.Checked = False Then
            pnlWardrobe.Enabled = True
            pnlWalkinCloset.Enabled = True
            rltWardrobe.Enabled = True
            rltWalkinCloset.Enabled = True
        ElseIf cbxWalkinCloset.Checked = False Then
            pnlWardrobe.Enabled = True
            pnlWalkinCloset.Enabled = True
            rltWardrobe.Enabled = True
            rltWalkinCloset.Enabled = True
        End If

        If cbxWardrobe.Checked = True Then
            pnlWalkinCloset.Enabled = False
            rltWardrobe.Enabled = False
            rltWardrobe.ClearSelection()
            rltWalkinCloset.ClearSelection()
        ElseIf cbxWalkinCloset.Checked = True Then
            pnlWardrobe.Enabled = False
            rltWalkinCloset.Enabled = False
            rltWardrobe.ClearSelection()
            rltWalkinCloset.ClearSelection()
        End If

    End Sub

    'FIREPLACE

    Protected Sub cbxBrick_CheckedChanged(sender As Object, e As EventArgs) Handles cbxBrick.CheckedChanged, cbxManufactured.CheckedChanged, cbxNatural.CheckedChanged
        If cbxBrick.Checked = False Then
            pnlBrick.Enabled = True
            pnlManufactured.Enabled = True
            pnlNatural.Enabled = True
            rltBrick.Enabled = True
            rltManufactured.Enabled = True
            rltNatural.Enabled = True
        ElseIf cbxManufactured.Checked = False Then
            pnlBrick.Enabled = True
            pnlManufactured.Enabled = True
            pnlNatural.Enabled = True
            rltBrick.Enabled = True
            rltManufactured.Enabled = True
            rltNatural.Enabled = True
        ElseIf cbxNatural.Checked = False Then
            pnlBrick.Enabled = True
            pnlManufactured.Enabled = True
            pnlNatural.Enabled = True
            rltBrick.Enabled = True
            rltManufactured.Enabled = True
            rltNatural.Enabled = True
        End If

        If cbxBrick.Checked = True Then
            pnlManufactured.Enabled = False
            pnlNatural.Enabled = False
            rltBrick.Enabled = False
            rltBrick.ClearSelection()
            rltManufactured.ClearSelection()
            rltNatural.ClearSelection()
        ElseIf cbxManufactured.Checked = True Then
            pnlBrick.Enabled = False
            pnlNatural.Enabled = False
            rltManufactured.Enabled = False
            rltBrick.ClearSelection()
            rltManufactured.ClearSelection()
            rltNatural.ClearSelection()
        ElseIf cbxNatural.Checked = True Then
            pnlManufactured.Enabled = False
            pnlBrick.Enabled = False
            rltNatural.Enabled = False
            rltBrick.ClearSelection()
            rltManufactured.ClearSelection()
            rltNatural.ClearSelection()
        End If

    End Sub

    Protected Sub btnOptomize_Click(sender As Object, e As EventArgs) Handles btnOptomize.Click

        myFeatureList = Session("myFeatures")

        Dim i As Integer = 0
        Dim featureName As String
        Dim ctlName As String
        Dim ctlNameList As New List(Of String)
        Dim ctl1 As Control
        Dim ctl2 As Control
        Dim ctl3 As Control

        For Each ctl1 In Page.Controls
            For Each ctl2 In ctl1.Controls
                If TypeOf ctl2 Is DropDownList Then
                    myFeatureList(i).Rating = CType(ctl2, DropDownList).SelectedValue
                End If
            Next
            For Each childCtl2 In ctl2.Controls
                ctlName = Convert.ToString(ctl2.ID)
                My.Computer.FileSystem.WriteAllText("C:\Users\mvans_000\Desktop\ctlNameList.txt", ctlName & vbCrLf, True)

                Next
                'featureName = Mid(Convert.ToString(ctl.ID), 4)

                'If TypeOf ctl Is CheckBox Then


                'End If

                'i += 1
            Next



        'FLOORING

        '    If cbxCarpet.Checked = True Then
        '    myFeatureList.Name(Carpet).Need = True
        'Else
        '    myFeatureList.GetName(Carpet).Preference = rltCarpet.SelectedValue
        'End If

        'If cbxTile.Checked = True Then
        '    myFeatureList.GetName(Tile).Need = True
        'Else
        '    myFeatureList.GetName(Tile).Preference = rltTile.SelectedValue
        'End If

        'If cbxHardwood.Checked = True Then
        '    myFeatureList.GetName(Hardwood).Need = True
        'Else
        '    myFeatureList.GetName(Hardwood).Preference = rltHardwood.SelectedValue
        'End If

        'If cbxTileShingle.Checked = True Then
        '    myFeatureList.GetName(Tile Shingle).Need = True
        'Else
        '    myFeatureList.GetName(Tile Shingle).Preference = rltTileShingle.SelectedValue
        'End If



        'ROOF TYPE

        '    If cbxAsphaltShingle.Checked = True Then
        '        myFeatureList.GetName(Asphalt Shingle).Need = True
        '    Else
        '        myFeatureList.GetName(Asphalt Shingle).Preference = rltAsphaltShingle.SelectedValue
        '    End If

        '    If cbxWoodShingle.Checked = True Then
        '        myFeatureList.GetName(Wood Shingle).Need = True
        '    Else
        '        myFeatureList.GetName(Wood Shingle).Preference = rltWoodShingle.SelectedValue
        '    End If

        '    If cbxMetalShingle.Checked = True Then
        '        myFeatureList.GetName(Metal Shingle).Need = True
        '    Else
        '        myFeatureList.GetName(Metal Shingle).Preference = rltMetalShingle.SelectedValue
        '    End If

        '    If cbxSlateShingle.Checked = True Then
        '        myFeatureList.GetName(Slate Shingle).Need = True
        '    Else
        '        myFeatureList.GetName(Slate Shingle).Preference = rltSlateShingle.SelectedValue
        '    End If


        '    'APPLIANCES

        '    If cbxStandardBeige.Checked = True Then
        '        myFeatureList.GetName(Standard Beige).Need = True
        '    Else
        '        myFeatureList.GetName(Standard Beige).Preference = rltStandardBeige.SelectedValue
        '    End If

        '    If cbxBlack.Checked = True Then
        '        myFeatureList.GetName(Black).Need = True
        '    Else
        '        myFeatureList.GetName(Black).Preference = rltBlack.SelectedValue
        '    End If

        '    If cbxStainlessSteel.Checked = True Then
        '        myFeatureList.GetName(Stainless Steel).Need = True
        '    Else
        '        myFeatureList.GetName(Stainless Steel).Preference = rltStainlessSteel.SelectedValue
        '    End If

        '    If cbxProfessional.Checked = True Then
        '        myFeatureList.GetName(Professional Grade).Need = True
        '    Else
        '        myFeatureList.GetName(Professional Grade).Preference = rltProfessional.SelectedValue
        '    End If


        '    'GARAGE

        '    If cbxOneCar.Checked = True Then
        '        myFeatureList.GetName(One Car).Need = True
        '    Else
        '        myFeatureList.GetName(One Car).Preference = rltOneCar.SelectedValue
        '    End If

        '    If cbxTwoCar.Checked = True Then
        '        myFeatureList.GetName(Two Car).Need = True
        '    Else
        '        myFeatureList.GetName(Two Car).Preference = rltTwoCar.SelectedValue
        '    End If

        '    If cbxThreeCar.Checked = True Then
        '        myFeatureList.GetName(Three Car).Need = True
        '    Else
        '        myFeatureList.GetName(Three Car).Preference = rltThreeCar.SelectedValue
        '    End If


        '    'COUNTERTOPS


        '    If cbxQuartz.Checked = True Then
        '        myFeatureList.GetName(Quartz).Need = True
        '    Else
        '        myFeatureList.GetName(Quartz).Preference = rltQuartz.SelectedValue
        '    End If

        '    If cbxGranite.Checked = True Then
        '        myFeatureList.GetName(Granite).Need = True
        '    Else
        '        myFeatureList.GetName(Granite).Preference = rltGranite.SelectedValue
        '    End If

        '    If cbxLaminate.Checked = True Then
        '        myFeatureList.GetName(Laminate).Need = True
        '    Else
        '        myFeatureList.GetName(Laminate).Preference = rltLaminate.SelectedValue
        '    End If

        '    If cbxWood.Checked = True Then
        '        myFeatureList.GetName(Wood).Need = True
        '    Else
        '        myFeatureList.GetName(Wood).Preference = rltWood.SelectedValue
        '    End If

        '    If cbxMarble.Checked = True Then
        '        myFeatureList.GetName(Marble).Need = True
        '    Else
        '        myFeatureList.GetName(Marble).Preference = rltMarble.SelectedValue
        '    End If


        '    'BATH

        '    If cbxBathShower.Checked = True Then
        '        myFeatureList.GetName(Bath/BathShower Combination).Need = True
        '    Else
        '        myFeatureList.GetName(Bath/BathShower Combination).Preference = rltBathShower.SelectedValue
        '    End If

        '    If cbxWalkinShower.Checked = True Then
        '        myFeatureList.GetName(Walk-in-Shower).Need = True
        '    Else
        '        myFeatureList.GetName(Walk-in-Shower).Preference = rltWalkinShower.SelectedValue
        '    End If

        '    If cbxRainfall.Checked = True Then
        '        myFeatureList.GetName(Luxury rainfall shower).Need = True
        '    Else
        '        myFeatureList.GetName(Luxury rainfall shower).Preference = rltRainfall.SelectedValue
        '    End If


        '    'CLOSET

        '    If cbxWardrobe.Checked = True Then
        '        myFeatureList.GetName(Wardrobe Closet).Need = True
        '    Else
        '        myFeatureList.GetName(Wardrobe Closet).Preference = rltWardrobe.SelectedValue
        '    End If

        '    If cbxWalkinCloset.Checked = True Then
        '        myFeatureList.GetName(Walk-in Closet).Need = True
        '    Else
        '        myFeatureList.GetName(Walk-in Closet).Preference = rltWalkinCloset.SelectedValue
        '    End If


        '    'FIREPLACE

        '    If cbxBrick.Checked = True Then
        '        myFeatureList.GetName(Brick Fireplace).Need = True
        '    Else
        '        myFeatureList.GetName(Brick Fireplace).Preference = rltBrick.SelectedValue
        '    End If

        '    If cbxManufactured.Checked = True Then
        '        myFeatureList.GetName(Manufactured Stone Fireplace).Need = True
        '    Else
        '        myFeatureList.GetName(Manufactured Stone Fireplace).Preference = rltManufactured.SelectedValue
        '    End If

        '    If cbxNatural.Checked = True Then
        '        myFeatureList.GetName(Natural Stone Fireplace).Need = True
        '    Else
        '        myFeatureList.GetName(Natural Stone Fireplace).Preference = rltNatural.SelectedValue
        '    End If

    End Sub
End Class


