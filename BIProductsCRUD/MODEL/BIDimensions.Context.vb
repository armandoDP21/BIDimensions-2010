﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class BIDimensionsContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=BIDimensionsContext")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property AUX_SYSTEM() As DbSet(Of AUX_SYSTEM)
    Public Overridable Property D01_PRODUCTS() As DbSet(Of D01_PRODUCTS)
    Public Overridable Property HOM_Brand() As DbSet(Of HOM_Brand)
    Public Overridable Property HOM_Flavor() As DbSet(Of HOM_Flavor)
    Public Overridable Property HOM_Presentation() As DbSet(Of HOM_Presentation)
    Public Overridable Property HOM_ProductGroup() As DbSet(Of HOM_ProductGroup)
    Public Overridable Property HOM_Size() As DbSet(Of HOM_Size)
    Public Overridable Property HOM_Source() As DbSet(Of HOM_Source)
    Public Overridable Property HOM_SubBrand() As DbSet(Of HOM_SubBrand)
    Public Overridable Property HOM_SubCategory() As DbSet(Of HOM_SubCategory)
    Public Overridable Property HOM_TypeBrand() As DbSet(Of HOM_TypeBrand)
    Public Overridable Property M01_Brand() As DbSet(Of M01_Brand)
    Public Overridable Property M01_Category() As DbSet(Of M01_Category)
    Public Overridable Property M01_Flavor() As DbSet(Of M01_Flavor)
    Public Overridable Property M01_POT_Status() As DbSet(Of M01_POT_Status)
    Public Overridable Property M01_Presentation() As DbSet(Of M01_Presentation)
    Public Overridable Property M01_ProductGroup() As DbSet(Of M01_ProductGroup)
    Public Overridable Property M01_Products() As DbSet(Of M01_Products)
    Public Overridable Property M01_Size() As DbSet(Of M01_Size)
    Public Overridable Property M01_Source() As DbSet(Of M01_Source)
    Public Overridable Property M01_SubBrand() As DbSet(Of M01_SubBrand)
    Public Overridable Property M01_SubCategory() As DbSet(Of M01_SubCategory)
    Public Overridable Property M01_TypeBrand() As DbSet(Of M01_TypeBrand)
    Public Overridable Property M01_TypeOFSales() As DbSet(Of M01_TypeOFSales)
    Public Overridable Property D02_CUSTOMERS() As DbSet(Of D02_CUSTOMERS)
    Public Overridable Property D05_GEOGRAPHY() As DbSet(Of D05_GEOGRAPHY)
    Public Overridable Property HOM_Branch() As DbSet(Of HOM_Branch)
    Public Overridable Property HOM_Chain() As DbSet(Of HOM_Chain)
    Public Overridable Property HOM_CustomerCategory() As DbSet(Of HOM_CustomerCategory)
    Public Overridable Property HOM_District() As DbSet(Of HOM_District)
    Public Overridable Property HOM_PayMethod() As DbSet(Of HOM_PayMethod)
    Public Overridable Property HOM_RSR() As DbSet(Of HOM_RSR)
    Public Overridable Property HOM_TypeRoute() As DbSet(Of HOM_TypeRoute)
    Public Overridable Property M02_Category() As DbSet(Of M02_Category)
    Public Overridable Property M02_Chain() As DbSet(Of M02_Chain)
    Public Overridable Property M02_Customers() As DbSet(Of M02_Customers)
    Public Overridable Property M02_KeyAccount() As DbSet(Of M02_KeyAccount)
    Public Overridable Property M02_PayMtMthod() As DbSet(Of M02_PayMtMthod)
    Public Overridable Property M05_Branch() As DbSet(Of M05_Branch)
    Public Overridable Property M05_Country() As DbSet(Of M05_Country)
    Public Overridable Property M05_District() As DbSet(Of M05_District)
    Public Overridable Property M05_Geography() As DbSet(Of M05_Geography)
    Public Overridable Property M05_Geography_Prueba() As DbSet(Of M05_Geography_Prueba)
    Public Overridable Property M05_Market_Unit() As DbSet(Of M05_Market_Unit)
    Public Overridable Property M05_Route_Representative() As DbSet(Of M05_Route_Representative)
    Public Overridable Property M05_TypeRoute() As DbSet(Of M05_TypeRoute)
    Public Overridable Property M05_Zone() As DbSet(Of M05_Zone)
    Public Overridable Property sysdiagrams() As DbSet(Of sysdiagrams)
    Public Overridable Property HOM_Country() As DbSet(Of HOM_Country)
    Public Overridable Property HOM_keyAccount() As DbSet(Of HOM_keyAccount)
    Public Overridable Property M02_Customers_bkp() As DbSet(Of M02_Customers_bkp)

End Class
