Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Namespace ManualBinding
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			' emulating an external data source
			If Session("RegionID") Is Nothing Then
				Session("RegionID") = 1
			End If
		End Sub

		Protected Sub ASPxComboBox1_PreRender(ByVal sender As Object, ByVal e As EventArgs)
			' fetch a value from a data source
			Dim regionID As Integer = CInt(Fix(Session("RegionID")))
			' manually assing the value to the ComboBox
			ASPxComboBox1.Value = regionID
		End Sub

		Protected Sub ASPxComboBox1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			' get a new value
			Dim regionID As Integer = CInt(Fix(ASPxComboBox1.Value))
			' save it to a data source
			Session("RegionID") = regionID

			'ASPxComboBox1.DataBind();
		End Sub

		Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			' emulate an external change of a data source
			Session("RegionID") = 2
		End Sub

	End Class
End Namespace
