﻿Imports System.ComponentModel
Imports System.Web.Services
Imports System.Web.Services.Protocols

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class ServicioLogin
    Inherits System.Web.Services.WebService
	Public authHeader Credentials As String 

	<WebMethod()>
	Public Function LoginWebService() As String
	{ 
	
	
		If Credentials.UserName.ToLower() IsNot "Admin" Or
		Credentials.Password.ToLower() IsNot "password12345" Then

			Throw New SoapException("No autorizado",
			SoapException.ClientFaultCode)


		Else
			Return "Este es un Servicio web"
		End If

	End Function


End Class