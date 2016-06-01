

'''<summary>
'''Represents a strongly typed in-memory cache of data.
'''</summary>
<Global.System.Serializable(),  _
 Global.System.ComponentModel.DesignerCategoryAttribute("code"),  _
 Global.System.ComponentModel.ToolboxItem(true),  _
 Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),  _
 Global.System.Xml.Serialization.XmlRootAttribute("ITB00500_PT_TICKT_TRACK_APPDataSet"),  _
 Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class ITB00500_PT_TICKT_TRACK_APPDataSet
    Inherits Global.System.Data.DataSet
    
    Private tableITT00501_PT_TICKT_MST As ITT00501_PT_TICKT_MSTDataTable
    
    Private tableITP00501_PT_TICKT_CHK_CMPLT_GET As ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable
    
    Private tableITP00501_PT_TICKT_GET As ITP00501_PT_TICKT_GETDataTable
    
    Private _schemaSerializationMode As Global.System.Data.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Sub New()
        MyBase.New
        Me.BeginInit
        Me.InitClass
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context, false)
        If (Me.IsBinarySerialized(info, context) = true) Then
            Me.InitVars(false)
            Dim schemaChangedHandler1 As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)),String)
        If (Me.DetermineSchemaSerializationMode(info, context) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet()
            ds.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("ITT00501_PT_TICKT_MST")) Is Nothing) Then
                MyBase.Tables.Add(New ITT00501_PT_TICKT_MSTDataTable(ds.Tables("ITT00501_PT_TICKT_MST")))
            End If
            If (Not (ds.Tables("ITP00501_PT_TICKT_CHK_CMPLT_GET")) Is Nothing) Then
                MyBase.Tables.Add(New ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable(ds.Tables("ITP00501_PT_TICKT_CHK_CMPLT_GET")))
            End If
            If (Not (ds.Tables("ITP00501_PT_TICKT_GET")) Is Nothing) Then
                MyBase.Tables.Add(New ITP00501_PT_TICKT_GETDataTable(ds.Tables("ITP00501_PT_TICKT_GET")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Browsable(false),  _
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property ITT00501_PT_TICKT_MST() As ITT00501_PT_TICKT_MSTDataTable
        Get
            Return Me.tableITT00501_PT_TICKT_MST
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Browsable(false),  _
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property ITP00501_PT_TICKT_CHK_CMPLT_GET() As ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable
        Get
            Return Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Browsable(false),  _
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property ITP00501_PT_TICKT_GET() As ITP00501_PT_TICKT_GETDataTable
        Get
            Return Me.tableITP00501_PT_TICKT_GET
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.BrowsableAttribute(true),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Visible)>  _
    Public Overrides Property SchemaSerializationMode() As Global.System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set
            Me._schemaSerializationMode = value
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Tables() As Global.System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Relations() As Global.System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit
        Me.InitClass
        Me.EndInit
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Overrides Function Clone() As Global.System.Data.DataSet
        Dim cln As ITB00500_PT_TICKT_TRACK_APPDataSet = CType(MyBase.Clone,ITB00500_PT_TICKT_TRACK_APPDataSet)
        cln.InitVars
        cln.SchemaSerializationMode = Me.SchemaSerializationMode
        Return cln
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As Global.System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet()
            ds.ReadXml(reader)
            If (Not (ds.Tables("ITT00501_PT_TICKT_MST")) Is Nothing) Then
                MyBase.Tables.Add(New ITT00501_PT_TICKT_MSTDataTable(ds.Tables("ITT00501_PT_TICKT_MST")))
            End If
            If (Not (ds.Tables("ITP00501_PT_TICKT_CHK_CMPLT_GET")) Is Nothing) Then
                MyBase.Tables.Add(New ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable(ds.Tables("ITP00501_PT_TICKT_CHK_CMPLT_GET")))
            End If
            If (Not (ds.Tables("ITP00501_PT_TICKT_GET")) Is Nothing) Then
                MyBase.Tables.Add(New ITP00501_PT_TICKT_GETDataTable(ds.Tables("ITP00501_PT_TICKT_GET")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXml(reader)
            Me.InitVars
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Overrides Function GetSchemaSerializable() As Global.System.Xml.Schema.XmlSchema
        Dim stream As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
        Me.WriteXmlSchema(New Global.System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return Global.System.Xml.Schema.XmlSchema.Read(New Global.System.Xml.XmlTextReader(stream), Nothing)
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Friend Overloads Sub InitVars()
        Me.InitVars(true)
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Friend Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tableITT00501_PT_TICKT_MST = CType(MyBase.Tables("ITT00501_PT_TICKT_MST"),ITT00501_PT_TICKT_MSTDataTable)
        If (initTable = true) Then
            If (Not (Me.tableITT00501_PT_TICKT_MST) Is Nothing) Then
                Me.tableITT00501_PT_TICKT_MST.InitVars
            End If
        End If
        Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET = CType(MyBase.Tables("ITP00501_PT_TICKT_CHK_CMPLT_GET"),ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable)
        If (initTable = true) Then
            If (Not (Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET) Is Nothing) Then
                Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.InitVars
            End If
        End If
        Me.tableITP00501_PT_TICKT_GET = CType(MyBase.Tables("ITP00501_PT_TICKT_GET"),ITP00501_PT_TICKT_GETDataTable)
        If (initTable = true) Then
            If (Not (Me.tableITP00501_PT_TICKT_GET) Is Nothing) Then
                Me.tableITP00501_PT_TICKT_GET.InitVars
            End If
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Sub InitClass()
        Me.DataSetName = "ITB00500_PT_TICKT_TRACK_APPDataSet"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/ITB00500_PT_TICKT_TRACK_APPDataSet.xsd"
        Me.EnforceConstraints = true
        Me.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
        Me.tableITT00501_PT_TICKT_MST = New ITT00501_PT_TICKT_MSTDataTable()
        MyBase.Tables.Add(Me.tableITT00501_PT_TICKT_MST)
        Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET = New ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable()
        MyBase.Tables.Add(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET)
        Me.tableITP00501_PT_TICKT_GET = New ITP00501_PT_TICKT_GETDataTable()
        MyBase.Tables.Add(Me.tableITP00501_PT_TICKT_GET)
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Function ShouldSerializeITT00501_PT_TICKT_MST() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Function ShouldSerializeITP00501_PT_TICKT_CHK_CMPLT_GET() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Function ShouldSerializeITP00501_PT_TICKT_GET() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As Global.System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = Global.System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Shared Function GetTypedDataSetSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
        Dim ds As ITB00500_PT_TICKT_TRACK_APPDataSet = New ITB00500_PT_TICKT_TRACK_APPDataSet()
        Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
        Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
        Dim any As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
        If xs.Contains(dsSchema.TargetNamespace) Then
            Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
            Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
            Try 
                Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                dsSchema.Write(s1)
                Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                Do While schemas.MoveNext
                    schema = CType(schemas.Current,Global.System.Xml.Schema.XmlSchema)
                    s2.SetLength(0)
                    schema.Write(s2)
                    If (s1.Length = s2.Length) Then
                        s1.Position = 0
                        s2.Position = 0
                        
                        Do While ((s1.Position <> s1.Length)  _
                                    AndAlso (s1.ReadByte = s2.ReadByte))
                            
                            
                        Loop
                        If (s1.Position = s1.Length) Then
                            Return type
                        End If
                    End If
                    
                Loop
            Finally
                If (Not (s1) Is Nothing) Then
                    s1.Close
                End If
                If (Not (s2) Is Nothing) Then
                    s2.Close
                End If
            End Try
        End If
        xs.Add(dsSchema)
        Return type
    End Function
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Delegate Sub ITT00501_PT_TICKT_MSTRowChangeEventHandler(ByVal sender As Object, ByVal e As ITT00501_PT_TICKT_MSTRowChangeEvent)
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Delegate Sub ITP00501_PT_TICKT_CHK_CMPLT_GETRowChangeEventHandler(ByVal sender As Object, ByVal e As ITP00501_PT_TICKT_CHK_CMPLT_GETRowChangeEvent)
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Delegate Sub ITP00501_PT_TICKT_GETRowChangeEventHandler(ByVal sender As Object, ByVal e As ITP00501_PT_TICKT_GETRowChangeEvent)
    
    '''<summary>
    '''Represents the strongly named DataTable class.
    '''</summary>
    <Global.System.Serializable(),  _
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>  _
    Partial Public Class ITT00501_PT_TICKT_MSTDataTable
        Inherits Global.System.Data.TypedTableBase(Of ITT00501_PT_TICKT_MSTRow)
        
        Private columnINCDNT_ID As Global.System.Data.DataColumn
        
        Private columnSUMM_DESC As Global.System.Data.DataColumn
        
        Private columnASSGN_ID As Global.System.Data.DataColumn
        
        Private columnRLATE_TXT As Global.System.Data.DataColumn
        
        Private columnNOTE_DESC As Global.System.Data.DataColumn
        
        Private columnCMPLT_FLG As Global.System.Data.DataColumn
        
        Private columnFIX_FLG As Global.System.Data.DataColumn
        
        Private columnCREAT_DTM As Global.System.Data.DataColumn
        
        Private columnAUDIT_CREAT_DTM As Global.System.Data.DataColumn
        
        Private columnAUDIT_UPDT_DTM As Global.System.Data.DataColumn
        
        Private columnAUDIT_HOST_ID As Global.System.Data.DataColumn
        
        Private columnAUDIT_USER_ID As Global.System.Data.DataColumn
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub New()
            MyBase.New
            Me.TableName = "ITT00501_PT_TICKT_MST"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property INCDNT_IDColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnINCDNT_ID
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property SUMM_DESCColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnSUMM_DESC
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property ASSGN_IDColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnASSGN_ID
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property RLATE_TXTColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnRLATE_TXT
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property NOTE_DESCColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnNOTE_DESC
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property CMPLT_FLGColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnCMPLT_FLG
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property FIX_FLGColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnFIX_FLG
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property CREAT_DTMColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnCREAT_DTM
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property AUDIT_CREAT_DTMColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnAUDIT_CREAT_DTM
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property AUDIT_UPDT_DTMColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnAUDIT_UPDT_DTM
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property AUDIT_HOST_IDColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnAUDIT_HOST_ID
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property AUDIT_USER_IDColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnAUDIT_USER_ID
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
         Global.System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Default ReadOnly Property Item(ByVal index As Integer) As ITT00501_PT_TICKT_MSTRow
            Get
                Return CType(Me.Rows(index),ITT00501_PT_TICKT_MSTRow)
            End Get
        End Property
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ITT00501_PT_TICKT_MSTRowChanging As ITT00501_PT_TICKT_MSTRowChangeEventHandler
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ITT00501_PT_TICKT_MSTRowChanged As ITT00501_PT_TICKT_MSTRowChangeEventHandler
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ITT00501_PT_TICKT_MSTRowDeleting As ITT00501_PT_TICKT_MSTRowChangeEventHandler
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ITT00501_PT_TICKT_MSTRowDeleted As ITT00501_PT_TICKT_MSTRowChangeEventHandler
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Overloads Sub AddITT00501_PT_TICKT_MSTRow(ByVal row As ITT00501_PT_TICKT_MSTRow)
            Me.Rows.Add(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Overloads Function AddITT00501_PT_TICKT_MSTRow(ByVal INCDNT_ID As String, ByVal SUMM_DESC As String, ByVal ASSGN_ID As String, ByVal RLATE_TXT As String, ByVal NOTE_DESC As String, ByVal CMPLT_FLG As Boolean, ByVal FIX_FLG As Boolean, ByVal CREAT_DTM As Date, ByVal AUDIT_CREAT_DTM As Date, ByVal AUDIT_UPDT_DTM As Date, ByVal AUDIT_HOST_ID As String, ByVal AUDIT_USER_ID As String) As ITT00501_PT_TICKT_MSTRow
            Dim rowITT00501_PT_TICKT_MSTRow As ITT00501_PT_TICKT_MSTRow = CType(Me.NewRow,ITT00501_PT_TICKT_MSTRow)
            Dim columnValuesArray() As Object = New Object() {INCDNT_ID, SUMM_DESC, ASSGN_ID, RLATE_TXT, NOTE_DESC, CMPLT_FLG, FIX_FLG, CREAT_DTM, AUDIT_CREAT_DTM, AUDIT_UPDT_DTM, AUDIT_HOST_ID, AUDIT_USER_ID}
            rowITT00501_PT_TICKT_MSTRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowITT00501_PT_TICKT_MSTRow)
            Return rowITT00501_PT_TICKT_MSTRow
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function FindByINCDNT_ID(ByVal INCDNT_ID As String) As ITT00501_PT_TICKT_MSTRow
            Return CType(Me.Rows.Find(New Object() {INCDNT_ID}),ITT00501_PT_TICKT_MSTRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As ITT00501_PT_TICKT_MSTDataTable = CType(MyBase.Clone,ITT00501_PT_TICKT_MSTDataTable)
            cln.InitVars
            Return cln
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New ITT00501_PT_TICKT_MSTDataTable()
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Friend Sub InitVars()
            Me.columnINCDNT_ID = MyBase.Columns("INCDNT_ID")
            Me.columnSUMM_DESC = MyBase.Columns("SUMM_DESC")
            Me.columnASSGN_ID = MyBase.Columns("ASSGN_ID")
            Me.columnRLATE_TXT = MyBase.Columns("RLATE_TXT")
            Me.columnNOTE_DESC = MyBase.Columns("NOTE_DESC")
            Me.columnCMPLT_FLG = MyBase.Columns("CMPLT_FLG")
            Me.columnFIX_FLG = MyBase.Columns("FIX_FLG")
            Me.columnCREAT_DTM = MyBase.Columns("CREAT_DTM")
            Me.columnAUDIT_CREAT_DTM = MyBase.Columns("AUDIT_CREAT_DTM")
            Me.columnAUDIT_UPDT_DTM = MyBase.Columns("AUDIT_UPDT_DTM")
            Me.columnAUDIT_HOST_ID = MyBase.Columns("AUDIT_HOST_ID")
            Me.columnAUDIT_USER_ID = MyBase.Columns("AUDIT_USER_ID")
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Private Sub InitClass()
            Me.columnINCDNT_ID = New Global.System.Data.DataColumn("INCDNT_ID", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnINCDNT_ID)
            Me.columnSUMM_DESC = New Global.System.Data.DataColumn("SUMM_DESC", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnSUMM_DESC)
            Me.columnASSGN_ID = New Global.System.Data.DataColumn("ASSGN_ID", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnASSGN_ID)
            Me.columnRLATE_TXT = New Global.System.Data.DataColumn("RLATE_TXT", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnRLATE_TXT)
            Me.columnNOTE_DESC = New Global.System.Data.DataColumn("NOTE_DESC", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnNOTE_DESC)
            Me.columnCMPLT_FLG = New Global.System.Data.DataColumn("CMPLT_FLG", GetType(Boolean), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnCMPLT_FLG)
            Me.columnFIX_FLG = New Global.System.Data.DataColumn("FIX_FLG", GetType(Boolean), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnFIX_FLG)
            Me.columnCREAT_DTM = New Global.System.Data.DataColumn("CREAT_DTM", GetType(Date), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnCREAT_DTM)
            Me.columnAUDIT_CREAT_DTM = New Global.System.Data.DataColumn("AUDIT_CREAT_DTM", GetType(Date), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnAUDIT_CREAT_DTM)
            Me.columnAUDIT_UPDT_DTM = New Global.System.Data.DataColumn("AUDIT_UPDT_DTM", GetType(Date), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnAUDIT_UPDT_DTM)
            Me.columnAUDIT_HOST_ID = New Global.System.Data.DataColumn("AUDIT_HOST_ID", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnAUDIT_HOST_ID)
            Me.columnAUDIT_USER_ID = New Global.System.Data.DataColumn("AUDIT_USER_ID", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnAUDIT_USER_ID)
            Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnINCDNT_ID}, true))
            Me.columnINCDNT_ID.AllowDBNull = false
            Me.columnINCDNT_ID.Unique = true
            Me.columnINCDNT_ID.MaxLength = 20
            Me.columnSUMM_DESC.MaxLength = 100
            Me.columnASSGN_ID.MaxLength = 100
            Me.columnRLATE_TXT.MaxLength = 75
            Me.columnNOTE_DESC.MaxLength = 200
            Me.columnCMPLT_FLG.AllowDBNull = false
            Me.columnFIX_FLG.AllowDBNull = false
            Me.columnAUDIT_CREAT_DTM.AllowDBNull = false
            Me.columnAUDIT_UPDT_DTM.AllowDBNull = false
            Me.columnAUDIT_HOST_ID.AllowDBNull = false
            Me.columnAUDIT_HOST_ID.MaxLength = 20
            Me.columnAUDIT_USER_ID.AllowDBNull = false
            Me.columnAUDIT_USER_ID.MaxLength = 20
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function NewITT00501_PT_TICKT_MSTRow() As ITT00501_PT_TICKT_MSTRow
            Return CType(Me.NewRow,ITT00501_PT_TICKT_MSTRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New ITT00501_PT_TICKT_MSTRow(builder)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(ITT00501_PT_TICKT_MSTRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ITT00501_PT_TICKT_MSTRowChangedEvent) Is Nothing) Then
                RaiseEvent ITT00501_PT_TICKT_MSTRowChanged(Me, New ITT00501_PT_TICKT_MSTRowChangeEvent(CType(e.Row,ITT00501_PT_TICKT_MSTRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ITT00501_PT_TICKT_MSTRowChangingEvent) Is Nothing) Then
                RaiseEvent ITT00501_PT_TICKT_MSTRowChanging(Me, New ITT00501_PT_TICKT_MSTRowChangeEvent(CType(e.Row,ITT00501_PT_TICKT_MSTRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ITT00501_PT_TICKT_MSTRowDeletedEvent) Is Nothing) Then
                RaiseEvent ITT00501_PT_TICKT_MSTRowDeleted(Me, New ITT00501_PT_TICKT_MSTRowChangeEvent(CType(e.Row,ITT00501_PT_TICKT_MSTRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ITT00501_PT_TICKT_MSTRowDeletingEvent) Is Nothing) Then
                RaiseEvent ITT00501_PT_TICKT_MSTRowDeleting(Me, New ITT00501_PT_TICKT_MSTRowChangeEvent(CType(e.Row,ITT00501_PT_TICKT_MSTRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub RemoveITT00501_PT_TICKT_MSTRow(ByVal row As ITT00501_PT_TICKT_MSTRow)
            Me.Rows.Remove(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As ITB00500_PT_TICKT_TRACK_APPDataSet = New ITB00500_PT_TICKT_TRACK_APPDataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "ITT00501_PT_TICKT_MSTDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try 
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current,Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0
                            
                            Do While ((s1.Position <> s1.Length)  _
                                        AndAlso (s1.ReadByte = s2.ReadByte))
                                
                                
                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If
                        
                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class
    
    '''<summary>
    '''Represents the strongly named DataTable class.
    '''</summary>
    <Global.System.Serializable(),  _
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>  _
    Partial Public Class ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable
        Inherits Global.System.Data.TypedTableBase(Of ITP00501_PT_TICKT_CHK_CMPLT_GETRow)
        
        Private columnINCDNT_ID As Global.System.Data.DataColumn
        
        Private columnSUMM_DESC As Global.System.Data.DataColumn
        
        Private columnASSGN_ID As Global.System.Data.DataColumn
        
        Private columnRLATE_TXT As Global.System.Data.DataColumn
        
        Private columnNOTE_DESC As Global.System.Data.DataColumn
        
        Private columnCMPLT_FLG As Global.System.Data.DataColumn
        
        Private columnFIX_FLG As Global.System.Data.DataColumn
        
        Private columnCREAT_DTM As Global.System.Data.DataColumn
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub New()
            MyBase.New
            Me.TableName = "ITP00501_PT_TICKT_CHK_CMPLT_GET"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property INCDNT_IDColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnINCDNT_ID
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property SUMM_DESCColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnSUMM_DESC
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property ASSGN_IDColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnASSGN_ID
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property RLATE_TXTColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnRLATE_TXT
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property NOTE_DESCColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnNOTE_DESC
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property CMPLT_FLGColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnCMPLT_FLG
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property FIX_FLGColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnFIX_FLG
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property CREAT_DTMColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnCREAT_DTM
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
         Global.System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Default ReadOnly Property Item(ByVal index As Integer) As ITP00501_PT_TICKT_CHK_CMPLT_GETRow
            Get
                Return CType(Me.Rows(index),ITP00501_PT_TICKT_CHK_CMPLT_GETRow)
            End Get
        End Property
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ITP00501_PT_TICKT_CHK_CMPLT_GETRowChanging As ITP00501_PT_TICKT_CHK_CMPLT_GETRowChangeEventHandler
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ITP00501_PT_TICKT_CHK_CMPLT_GETRowChanged As ITP00501_PT_TICKT_CHK_CMPLT_GETRowChangeEventHandler
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ITP00501_PT_TICKT_CHK_CMPLT_GETRowDeleting As ITP00501_PT_TICKT_CHK_CMPLT_GETRowChangeEventHandler
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ITP00501_PT_TICKT_CHK_CMPLT_GETRowDeleted As ITP00501_PT_TICKT_CHK_CMPLT_GETRowChangeEventHandler
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Overloads Sub AddITP00501_PT_TICKT_CHK_CMPLT_GETRow(ByVal row As ITP00501_PT_TICKT_CHK_CMPLT_GETRow)
            Me.Rows.Add(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Overloads Function AddITP00501_PT_TICKT_CHK_CMPLT_GETRow(ByVal INCDNT_ID As String, ByVal SUMM_DESC As String, ByVal ASSGN_ID As String, ByVal RLATE_TXT As String, ByVal NOTE_DESC As String, ByVal CMPLT_FLG As Boolean, ByVal FIX_FLG As Boolean, ByVal CREAT_DTM As Date) As ITP00501_PT_TICKT_CHK_CMPLT_GETRow
            Dim rowITP00501_PT_TICKT_CHK_CMPLT_GETRow As ITP00501_PT_TICKT_CHK_CMPLT_GETRow = CType(Me.NewRow,ITP00501_PT_TICKT_CHK_CMPLT_GETRow)
            Dim columnValuesArray() As Object = New Object() {INCDNT_ID, SUMM_DESC, ASSGN_ID, RLATE_TXT, NOTE_DESC, CMPLT_FLG, FIX_FLG, CREAT_DTM}
            rowITP00501_PT_TICKT_CHK_CMPLT_GETRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowITP00501_PT_TICKT_CHK_CMPLT_GETRow)
            Return rowITP00501_PT_TICKT_CHK_CMPLT_GETRow
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function FindByINCDNT_ID(ByVal INCDNT_ID As String) As ITP00501_PT_TICKT_CHK_CMPLT_GETRow
            Return CType(Me.Rows.Find(New Object() {INCDNT_ID}),ITP00501_PT_TICKT_CHK_CMPLT_GETRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable = CType(MyBase.Clone,ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable)
            cln.InitVars
            Return cln
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable()
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Friend Sub InitVars()
            Me.columnINCDNT_ID = MyBase.Columns("INCDNT_ID")
            Me.columnSUMM_DESC = MyBase.Columns("SUMM_DESC")
            Me.columnASSGN_ID = MyBase.Columns("ASSGN_ID")
            Me.columnRLATE_TXT = MyBase.Columns("RLATE_TXT")
            Me.columnNOTE_DESC = MyBase.Columns("NOTE_DESC")
            Me.columnCMPLT_FLG = MyBase.Columns("CMPLT_FLG")
            Me.columnFIX_FLG = MyBase.Columns("FIX_FLG")
            Me.columnCREAT_DTM = MyBase.Columns("CREAT_DTM")
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Private Sub InitClass()
            Me.columnINCDNT_ID = New Global.System.Data.DataColumn("INCDNT_ID", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnINCDNT_ID)
            Me.columnSUMM_DESC = New Global.System.Data.DataColumn("SUMM_DESC", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnSUMM_DESC)
            Me.columnASSGN_ID = New Global.System.Data.DataColumn("ASSGN_ID", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnASSGN_ID)
            Me.columnRLATE_TXT = New Global.System.Data.DataColumn("RLATE_TXT", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnRLATE_TXT)
            Me.columnNOTE_DESC = New Global.System.Data.DataColumn("NOTE_DESC", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnNOTE_DESC)
            Me.columnCMPLT_FLG = New Global.System.Data.DataColumn("CMPLT_FLG", GetType(Boolean), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnCMPLT_FLG)
            Me.columnFIX_FLG = New Global.System.Data.DataColumn("FIX_FLG", GetType(Boolean), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnFIX_FLG)
            Me.columnCREAT_DTM = New Global.System.Data.DataColumn("CREAT_DTM", GetType(Date), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnCREAT_DTM)
            Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnINCDNT_ID}, true))
            Me.columnINCDNT_ID.AllowDBNull = false
            Me.columnINCDNT_ID.Unique = true
            Me.columnINCDNT_ID.MaxLength = 20
            Me.columnSUMM_DESC.MaxLength = 100
            Me.columnASSGN_ID.MaxLength = 100
            Me.columnRLATE_TXT.MaxLength = 75
            Me.columnNOTE_DESC.MaxLength = 200
            Me.columnCMPLT_FLG.AllowDBNull = false
            Me.columnFIX_FLG.AllowDBNull = false
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function NewITP00501_PT_TICKT_CHK_CMPLT_GETRow() As ITP00501_PT_TICKT_CHK_CMPLT_GETRow
            Return CType(Me.NewRow,ITP00501_PT_TICKT_CHK_CMPLT_GETRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New ITP00501_PT_TICKT_CHK_CMPLT_GETRow(builder)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(ITP00501_PT_TICKT_CHK_CMPLT_GETRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ITP00501_PT_TICKT_CHK_CMPLT_GETRowChangedEvent) Is Nothing) Then
                RaiseEvent ITP00501_PT_TICKT_CHK_CMPLT_GETRowChanged(Me, New ITP00501_PT_TICKT_CHK_CMPLT_GETRowChangeEvent(CType(e.Row,ITP00501_PT_TICKT_CHK_CMPLT_GETRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ITP00501_PT_TICKT_CHK_CMPLT_GETRowChangingEvent) Is Nothing) Then
                RaiseEvent ITP00501_PT_TICKT_CHK_CMPLT_GETRowChanging(Me, New ITP00501_PT_TICKT_CHK_CMPLT_GETRowChangeEvent(CType(e.Row,ITP00501_PT_TICKT_CHK_CMPLT_GETRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ITP00501_PT_TICKT_CHK_CMPLT_GETRowDeletedEvent) Is Nothing) Then
                RaiseEvent ITP00501_PT_TICKT_CHK_CMPLT_GETRowDeleted(Me, New ITP00501_PT_TICKT_CHK_CMPLT_GETRowChangeEvent(CType(e.Row,ITP00501_PT_TICKT_CHK_CMPLT_GETRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ITP00501_PT_TICKT_CHK_CMPLT_GETRowDeletingEvent) Is Nothing) Then
                RaiseEvent ITP00501_PT_TICKT_CHK_CMPLT_GETRowDeleting(Me, New ITP00501_PT_TICKT_CHK_CMPLT_GETRowChangeEvent(CType(e.Row,ITP00501_PT_TICKT_CHK_CMPLT_GETRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub RemoveITP00501_PT_TICKT_CHK_CMPLT_GETRow(ByVal row As ITP00501_PT_TICKT_CHK_CMPLT_GETRow)
            Me.Rows.Remove(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As ITB00500_PT_TICKT_TRACK_APPDataSet = New ITB00500_PT_TICKT_TRACK_APPDataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try 
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current,Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0
                            
                            Do While ((s1.Position <> s1.Length)  _
                                        AndAlso (s1.ReadByte = s2.ReadByte))
                                
                                
                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If
                        
                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class
    
    '''<summary>
    '''Represents the strongly named DataTable class.
    '''</summary>
    <Global.System.Serializable(),  _
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>  _
    Partial Public Class ITP00501_PT_TICKT_GETDataTable
        Inherits Global.System.Data.TypedTableBase(Of ITP00501_PT_TICKT_GETRow)
        
        Private columnSUMM_DESC As Global.System.Data.DataColumn
        
        Private columnASSGN_ID As Global.System.Data.DataColumn
        
        Private columnRLATE_TXT As Global.System.Data.DataColumn
        
        Private columnNOTE_DESC As Global.System.Data.DataColumn
        
        Private columnCMPLT_FLG As Global.System.Data.DataColumn
        
        Private columnFIX_FLG As Global.System.Data.DataColumn
        
        Private columnCREAT_DTM As Global.System.Data.DataColumn
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub New()
            MyBase.New
            Me.TableName = "ITP00501_PT_TICKT_GET"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property SUMM_DESCColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnSUMM_DESC
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property ASSGN_IDColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnASSGN_ID
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property RLATE_TXTColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnRLATE_TXT
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property NOTE_DESCColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnNOTE_DESC
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property CMPLT_FLGColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnCMPLT_FLG
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property FIX_FLGColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnFIX_FLG
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property CREAT_DTMColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnCREAT_DTM
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
         Global.System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Default ReadOnly Property Item(ByVal index As Integer) As ITP00501_PT_TICKT_GETRow
            Get
                Return CType(Me.Rows(index),ITP00501_PT_TICKT_GETRow)
            End Get
        End Property
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ITP00501_PT_TICKT_GETRowChanging As ITP00501_PT_TICKT_GETRowChangeEventHandler
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ITP00501_PT_TICKT_GETRowChanged As ITP00501_PT_TICKT_GETRowChangeEventHandler
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ITP00501_PT_TICKT_GETRowDeleting As ITP00501_PT_TICKT_GETRowChangeEventHandler
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Event ITP00501_PT_TICKT_GETRowDeleted As ITP00501_PT_TICKT_GETRowChangeEventHandler
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Overloads Sub AddITP00501_PT_TICKT_GETRow(ByVal row As ITP00501_PT_TICKT_GETRow)
            Me.Rows.Add(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Overloads Function AddITP00501_PT_TICKT_GETRow(ByVal SUMM_DESC As String, ByVal ASSGN_ID As String, ByVal RLATE_TXT As String, ByVal NOTE_DESC As String, ByVal CMPLT_FLG As Boolean, ByVal FIX_FLG As Boolean, ByVal CREAT_DTM As Date) As ITP00501_PT_TICKT_GETRow
            Dim rowITP00501_PT_TICKT_GETRow As ITP00501_PT_TICKT_GETRow = CType(Me.NewRow,ITP00501_PT_TICKT_GETRow)
            Dim columnValuesArray() As Object = New Object() {SUMM_DESC, ASSGN_ID, RLATE_TXT, NOTE_DESC, CMPLT_FLG, FIX_FLG, CREAT_DTM}
            rowITP00501_PT_TICKT_GETRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowITP00501_PT_TICKT_GETRow)
            Return rowITP00501_PT_TICKT_GETRow
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As ITP00501_PT_TICKT_GETDataTable = CType(MyBase.Clone,ITP00501_PT_TICKT_GETDataTable)
            cln.InitVars
            Return cln
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New ITP00501_PT_TICKT_GETDataTable()
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Friend Sub InitVars()
            Me.columnSUMM_DESC = MyBase.Columns("SUMM_DESC")
            Me.columnASSGN_ID = MyBase.Columns("ASSGN_ID")
            Me.columnRLATE_TXT = MyBase.Columns("RLATE_TXT")
            Me.columnNOTE_DESC = MyBase.Columns("NOTE_DESC")
            Me.columnCMPLT_FLG = MyBase.Columns("CMPLT_FLG")
            Me.columnFIX_FLG = MyBase.Columns("FIX_FLG")
            Me.columnCREAT_DTM = MyBase.Columns("CREAT_DTM")
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Private Sub InitClass()
            Me.columnSUMM_DESC = New Global.System.Data.DataColumn("SUMM_DESC", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnSUMM_DESC)
            Me.columnASSGN_ID = New Global.System.Data.DataColumn("ASSGN_ID", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnASSGN_ID)
            Me.columnRLATE_TXT = New Global.System.Data.DataColumn("RLATE_TXT", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnRLATE_TXT)
            Me.columnNOTE_DESC = New Global.System.Data.DataColumn("NOTE_DESC", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnNOTE_DESC)
            Me.columnCMPLT_FLG = New Global.System.Data.DataColumn("CMPLT_FLG", GetType(Boolean), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnCMPLT_FLG)
            Me.columnFIX_FLG = New Global.System.Data.DataColumn("FIX_FLG", GetType(Boolean), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnFIX_FLG)
            Me.columnCREAT_DTM = New Global.System.Data.DataColumn("CREAT_DTM", GetType(Date), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnCREAT_DTM)
            Me.columnSUMM_DESC.MaxLength = 100
            Me.columnASSGN_ID.MaxLength = 100
            Me.columnRLATE_TXT.MaxLength = 75
            Me.columnNOTE_DESC.MaxLength = 200
            Me.columnCMPLT_FLG.AllowDBNull = false
            Me.columnFIX_FLG.AllowDBNull = false
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function NewITP00501_PT_TICKT_GETRow() As ITP00501_PT_TICKT_GETRow
            Return CType(Me.NewRow,ITP00501_PT_TICKT_GETRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New ITP00501_PT_TICKT_GETRow(builder)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(ITP00501_PT_TICKT_GETRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ITP00501_PT_TICKT_GETRowChangedEvent) Is Nothing) Then
                RaiseEvent ITP00501_PT_TICKT_GETRowChanged(Me, New ITP00501_PT_TICKT_GETRowChangeEvent(CType(e.Row,ITP00501_PT_TICKT_GETRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ITP00501_PT_TICKT_GETRowChangingEvent) Is Nothing) Then
                RaiseEvent ITP00501_PT_TICKT_GETRowChanging(Me, New ITP00501_PT_TICKT_GETRowChangeEvent(CType(e.Row,ITP00501_PT_TICKT_GETRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ITP00501_PT_TICKT_GETRowDeletedEvent) Is Nothing) Then
                RaiseEvent ITP00501_PT_TICKT_GETRowDeleted(Me, New ITP00501_PT_TICKT_GETRowChangeEvent(CType(e.Row,ITP00501_PT_TICKT_GETRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ITP00501_PT_TICKT_GETRowDeletingEvent) Is Nothing) Then
                RaiseEvent ITP00501_PT_TICKT_GETRowDeleting(Me, New ITP00501_PT_TICKT_GETRowChangeEvent(CType(e.Row,ITP00501_PT_TICKT_GETRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub RemoveITP00501_PT_TICKT_GETRow(ByVal row As ITP00501_PT_TICKT_GETRow)
            Me.Rows.Remove(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As ITB00500_PT_TICKT_TRACK_APPDataSet = New ITB00500_PT_TICKT_TRACK_APPDataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "ITP00501_PT_TICKT_GETDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try 
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current,Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0
                            
                            Do While ((s1.Position <> s1.Length)  _
                                        AndAlso (s1.ReadByte = s2.ReadByte))
                                
                                
                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If
                        
                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class
    
    '''<summary>
    '''Represents strongly named DataRow class.
    '''</summary>
    Partial Public Class ITT00501_PT_TICKT_MSTRow
        Inherits Global.System.Data.DataRow
        
        Private tableITT00501_PT_TICKT_MST As ITT00501_PT_TICKT_MSTDataTable
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableITT00501_PT_TICKT_MST = CType(Me.Table,ITT00501_PT_TICKT_MSTDataTable)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property INCDNT_ID() As String
            Get
                Return CType(Me(Me.tableITT00501_PT_TICKT_MST.INCDNT_IDColumn),String)
            End Get
            Set
                Me(Me.tableITT00501_PT_TICKT_MST.INCDNT_IDColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property SUMM_DESC() As String
            Get
                Try 
                    Return CType(Me(Me.tableITT00501_PT_TICKT_MST.SUMM_DESCColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'SUMM_DESC' in table 'ITT00501_PT_TICKT_MST' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableITT00501_PT_TICKT_MST.SUMM_DESCColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property ASSGN_ID() As String
            Get
                Try 
                    Return CType(Me(Me.tableITT00501_PT_TICKT_MST.ASSGN_IDColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'ASSGN_ID' in table 'ITT00501_PT_TICKT_MST' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableITT00501_PT_TICKT_MST.ASSGN_IDColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property RLATE_TXT() As String
            Get
                Try 
                    Return CType(Me(Me.tableITT00501_PT_TICKT_MST.RLATE_TXTColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'RLATE_TXT' in table 'ITT00501_PT_TICKT_MST' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableITT00501_PT_TICKT_MST.RLATE_TXTColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property NOTE_DESC() As String
            Get
                Try 
                    Return CType(Me(Me.tableITT00501_PT_TICKT_MST.NOTE_DESCColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'NOTE_DESC' in table 'ITT00501_PT_TICKT_MST' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableITT00501_PT_TICKT_MST.NOTE_DESCColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property CMPLT_FLG() As Boolean
            Get
                Return CType(Me(Me.tableITT00501_PT_TICKT_MST.CMPLT_FLGColumn),Boolean)
            End Get
            Set
                Me(Me.tableITT00501_PT_TICKT_MST.CMPLT_FLGColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property FIX_FLG() As Boolean
            Get
                Return CType(Me(Me.tableITT00501_PT_TICKT_MST.FIX_FLGColumn),Boolean)
            End Get
            Set
                Me(Me.tableITT00501_PT_TICKT_MST.FIX_FLGColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property CREAT_DTM() As Date
            Get
                Try 
                    Return CType(Me(Me.tableITT00501_PT_TICKT_MST.CREAT_DTMColumn),Date)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'CREAT_DTM' in table 'ITT00501_PT_TICKT_MST' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableITT00501_PT_TICKT_MST.CREAT_DTMColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property AUDIT_CREAT_DTM() As Date
            Get
                Return CType(Me(Me.tableITT00501_PT_TICKT_MST.AUDIT_CREAT_DTMColumn),Date)
            End Get
            Set
                Me(Me.tableITT00501_PT_TICKT_MST.AUDIT_CREAT_DTMColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property AUDIT_UPDT_DTM() As Date
            Get
                Return CType(Me(Me.tableITT00501_PT_TICKT_MST.AUDIT_UPDT_DTMColumn),Date)
            End Get
            Set
                Me(Me.tableITT00501_PT_TICKT_MST.AUDIT_UPDT_DTMColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property AUDIT_HOST_ID() As String
            Get
                Return CType(Me(Me.tableITT00501_PT_TICKT_MST.AUDIT_HOST_IDColumn),String)
            End Get
            Set
                Me(Me.tableITT00501_PT_TICKT_MST.AUDIT_HOST_IDColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property AUDIT_USER_ID() As String
            Get
                Return CType(Me(Me.tableITT00501_PT_TICKT_MST.AUDIT_USER_IDColumn),String)
            End Get
            Set
                Me(Me.tableITT00501_PT_TICKT_MST.AUDIT_USER_IDColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsSUMM_DESCNull() As Boolean
            Return Me.IsNull(Me.tableITT00501_PT_TICKT_MST.SUMM_DESCColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetSUMM_DESCNull()
            Me(Me.tableITT00501_PT_TICKT_MST.SUMM_DESCColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsASSGN_IDNull() As Boolean
            Return Me.IsNull(Me.tableITT00501_PT_TICKT_MST.ASSGN_IDColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetASSGN_IDNull()
            Me(Me.tableITT00501_PT_TICKT_MST.ASSGN_IDColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsRLATE_TXTNull() As Boolean
            Return Me.IsNull(Me.tableITT00501_PT_TICKT_MST.RLATE_TXTColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetRLATE_TXTNull()
            Me(Me.tableITT00501_PT_TICKT_MST.RLATE_TXTColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsNOTE_DESCNull() As Boolean
            Return Me.IsNull(Me.tableITT00501_PT_TICKT_MST.NOTE_DESCColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetNOTE_DESCNull()
            Me(Me.tableITT00501_PT_TICKT_MST.NOTE_DESCColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsCREAT_DTMNull() As Boolean
            Return Me.IsNull(Me.tableITT00501_PT_TICKT_MST.CREAT_DTMColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetCREAT_DTMNull()
            Me(Me.tableITT00501_PT_TICKT_MST.CREAT_DTMColumn) = Global.System.Convert.DBNull
        End Sub
    End Class
    
    '''<summary>
    '''Represents strongly named DataRow class.
    '''</summary>
    Partial Public Class ITP00501_PT_TICKT_CHK_CMPLT_GETRow
        Inherits Global.System.Data.DataRow
        
        Private tableITP00501_PT_TICKT_CHK_CMPLT_GET As ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET = CType(Me.Table,ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property INCDNT_ID() As String
            Get
                Return CType(Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.INCDNT_IDColumn),String)
            End Get
            Set
                Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.INCDNT_IDColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property SUMM_DESC() As String
            Get
                Try 
                    Return CType(Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.SUMM_DESCColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'SUMM_DESC' in table 'ITP00501_PT_TICKT_CHK_CMPLT_GET' is DB"& _ 
                            "Null.", e)
                End Try
            End Get
            Set
                Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.SUMM_DESCColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property ASSGN_ID() As String
            Get
                Try 
                    Return CType(Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.ASSGN_IDColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'ASSGN_ID' in table 'ITP00501_PT_TICKT_CHK_CMPLT_GET' is DBN"& _ 
                            "ull.", e)
                End Try
            End Get
            Set
                Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.ASSGN_IDColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property RLATE_TXT() As String
            Get
                Try 
                    Return CType(Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.RLATE_TXTColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'RLATE_TXT' in table 'ITP00501_PT_TICKT_CHK_CMPLT_GET' is DB"& _ 
                            "Null.", e)
                End Try
            End Get
            Set
                Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.RLATE_TXTColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property NOTE_DESC() As String
            Get
                Try 
                    Return CType(Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.NOTE_DESCColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'NOTE_DESC' in table 'ITP00501_PT_TICKT_CHK_CMPLT_GET' is DB"& _ 
                            "Null.", e)
                End Try
            End Get
            Set
                Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.NOTE_DESCColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property CMPLT_FLG() As Boolean
            Get
                Return CType(Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.CMPLT_FLGColumn),Boolean)
            End Get
            Set
                Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.CMPLT_FLGColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property FIX_FLG() As Boolean
            Get
                Return CType(Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.FIX_FLGColumn),Boolean)
            End Get
            Set
                Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.FIX_FLGColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property CREAT_DTM() As Date
            Get
                Try 
                    Return CType(Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.CREAT_DTMColumn),Date)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'CREAT_DTM' in table 'ITP00501_PT_TICKT_CHK_CMPLT_GET' is DB"& _ 
                            "Null.", e)
                End Try
            End Get
            Set
                Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.CREAT_DTMColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsSUMM_DESCNull() As Boolean
            Return Me.IsNull(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.SUMM_DESCColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetSUMM_DESCNull()
            Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.SUMM_DESCColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsASSGN_IDNull() As Boolean
            Return Me.IsNull(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.ASSGN_IDColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetASSGN_IDNull()
            Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.ASSGN_IDColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsRLATE_TXTNull() As Boolean
            Return Me.IsNull(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.RLATE_TXTColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetRLATE_TXTNull()
            Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.RLATE_TXTColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsNOTE_DESCNull() As Boolean
            Return Me.IsNull(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.NOTE_DESCColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetNOTE_DESCNull()
            Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.NOTE_DESCColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsCREAT_DTMNull() As Boolean
            Return Me.IsNull(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.CREAT_DTMColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetCREAT_DTMNull()
            Me(Me.tableITP00501_PT_TICKT_CHK_CMPLT_GET.CREAT_DTMColumn) = Global.System.Convert.DBNull
        End Sub
    End Class
    
    '''<summary>
    '''Represents strongly named DataRow class.
    '''</summary>
    Partial Public Class ITP00501_PT_TICKT_GETRow
        Inherits Global.System.Data.DataRow
        
        Private tableITP00501_PT_TICKT_GET As ITP00501_PT_TICKT_GETDataTable
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableITP00501_PT_TICKT_GET = CType(Me.Table,ITP00501_PT_TICKT_GETDataTable)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property SUMM_DESC() As String
            Get
                Try 
                    Return CType(Me(Me.tableITP00501_PT_TICKT_GET.SUMM_DESCColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'SUMM_DESC' in table 'ITP00501_PT_TICKT_GET' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableITP00501_PT_TICKT_GET.SUMM_DESCColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property ASSGN_ID() As String
            Get
                Try 
                    Return CType(Me(Me.tableITP00501_PT_TICKT_GET.ASSGN_IDColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'ASSGN_ID' in table 'ITP00501_PT_TICKT_GET' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableITP00501_PT_TICKT_GET.ASSGN_IDColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property RLATE_TXT() As String
            Get
                Try 
                    Return CType(Me(Me.tableITP00501_PT_TICKT_GET.RLATE_TXTColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'RLATE_TXT' in table 'ITP00501_PT_TICKT_GET' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableITP00501_PT_TICKT_GET.RLATE_TXTColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property NOTE_DESC() As String
            Get
                Try 
                    Return CType(Me(Me.tableITP00501_PT_TICKT_GET.NOTE_DESCColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'NOTE_DESC' in table 'ITP00501_PT_TICKT_GET' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableITP00501_PT_TICKT_GET.NOTE_DESCColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property CMPLT_FLG() As Boolean
            Get
                Return CType(Me(Me.tableITP00501_PT_TICKT_GET.CMPLT_FLGColumn),Boolean)
            End Get
            Set
                Me(Me.tableITP00501_PT_TICKT_GET.CMPLT_FLGColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property FIX_FLG() As Boolean
            Get
                Return CType(Me(Me.tableITP00501_PT_TICKT_GET.FIX_FLGColumn),Boolean)
            End Get
            Set
                Me(Me.tableITP00501_PT_TICKT_GET.FIX_FLGColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Property CREAT_DTM() As Date
            Get
                Try 
                    Return CType(Me(Me.tableITP00501_PT_TICKT_GET.CREAT_DTMColumn),Date)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'CREAT_DTM' in table 'ITP00501_PT_TICKT_GET' is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableITP00501_PT_TICKT_GET.CREAT_DTMColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsSUMM_DESCNull() As Boolean
            Return Me.IsNull(Me.tableITP00501_PT_TICKT_GET.SUMM_DESCColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetSUMM_DESCNull()
            Me(Me.tableITP00501_PT_TICKT_GET.SUMM_DESCColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsASSGN_IDNull() As Boolean
            Return Me.IsNull(Me.tableITP00501_PT_TICKT_GET.ASSGN_IDColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetASSGN_IDNull()
            Me(Me.tableITP00501_PT_TICKT_GET.ASSGN_IDColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsRLATE_TXTNull() As Boolean
            Return Me.IsNull(Me.tableITP00501_PT_TICKT_GET.RLATE_TXTColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetRLATE_TXTNull()
            Me(Me.tableITP00501_PT_TICKT_GET.RLATE_TXTColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsNOTE_DESCNull() As Boolean
            Return Me.IsNull(Me.tableITP00501_PT_TICKT_GET.NOTE_DESCColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetNOTE_DESCNull()
            Me(Me.tableITP00501_PT_TICKT_GET.NOTE_DESCColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function IsCREAT_DTMNull() As Boolean
            Return Me.IsNull(Me.tableITP00501_PT_TICKT_GET.CREAT_DTMColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub SetCREAT_DTMNull()
            Me(Me.tableITP00501_PT_TICKT_GET.CREAT_DTMColumn) = Global.System.Convert.DBNull
        End Sub
    End Class
    
    '''<summary>
    '''Row event argument class
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Class ITT00501_PT_TICKT_MSTRowChangeEvent
        Inherits Global.System.EventArgs
        
        Private eventRow As ITT00501_PT_TICKT_MSTRow
        
        Private eventAction As Global.System.Data.DataRowAction
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub New(ByVal row As ITT00501_PT_TICKT_MSTRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property Row() As ITT00501_PT_TICKT_MSTRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    '''<summary>
    '''Row event argument class
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Class ITP00501_PT_TICKT_CHK_CMPLT_GETRowChangeEvent
        Inherits Global.System.EventArgs
        
        Private eventRow As ITP00501_PT_TICKT_CHK_CMPLT_GETRow
        
        Private eventAction As Global.System.Data.DataRowAction
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub New(ByVal row As ITP00501_PT_TICKT_CHK_CMPLT_GETRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property Row() As ITP00501_PT_TICKT_CHK_CMPLT_GETRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    '''<summary>
    '''Row event argument class
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Class ITP00501_PT_TICKT_GETRowChangeEvent
        Inherits Global.System.EventArgs
        
        Private eventRow As ITP00501_PT_TICKT_GETRow
        
        Private eventAction As Global.System.Data.DataRowAction
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Sub New(ByVal row As ITP00501_PT_TICKT_GETRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property Row() As ITP00501_PT_TICKT_GETRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class

'''<summary>
'''Represents the connection and commands used to retrieve and save data.
'''</summary>
<Global.System.ComponentModel.DesignerCategoryAttribute("code"),  _
 Global.System.ComponentModel.ToolboxItem(true),  _
 Global.System.ComponentModel.DataObjectAttribute(true),  _
 Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner"& _ 
    ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"),  _
 Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
Partial Public Class ITB00500_PT_TICKT_TRACK_APPDataSetITT00501_PT_TICKT_MSTTableAdapter
    Inherits Global.System.ComponentModel.Component
    
    Private WithEvents _adapter As Global.System.Data.SqlClient.SqlDataAdapter
    
    Private _connection As Global.System.Data.SqlClient.SqlConnection
    
    Private _transaction As Global.System.Data.SqlClient.SqlTransaction
    
    Private _commandCollection() As Global.System.Data.SqlClient.SqlCommand
    
    Private _clearBeforeFill As Boolean
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Sub New()
        MyBase.New
        Me.ClearBeforeFill = true
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Friend ReadOnly Property Adapter() As Global.System.Data.SqlClient.SqlDataAdapter
        Get
            If (Me._adapter Is Nothing) Then
                Me.InitAdapter
            End If
            Return Me._adapter
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Friend Property Connection() As Global.System.Data.SqlClient.SqlConnection
        Get
            If (Me._connection Is Nothing) Then
                Me.InitConnection
            End If
            Return Me._connection
        End Get
        Set
            Me._connection = value
            If (Not (Me.Adapter.InsertCommand) Is Nothing) Then
                Me.Adapter.InsertCommand.Connection = value
            End If
            If (Not (Me.Adapter.DeleteCommand) Is Nothing) Then
                Me.Adapter.DeleteCommand.Connection = value
            End If
            If (Not (Me.Adapter.UpdateCommand) Is Nothing) Then
                Me.Adapter.UpdateCommand.Connection = value
            End If
            Dim i As Integer = 0
            Do While (i < Me.CommandCollection.Length)
                If (Not (Me.CommandCollection(i)) Is Nothing) Then
                    CType(Me.CommandCollection(i),Global.System.Data.SqlClient.SqlCommand).Connection = value
                End If
                i = (i + 1)
            Loop
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Friend Property Transaction() As Global.System.Data.SqlClient.SqlTransaction
        Get
            Return Me._transaction
        End Get
        Set
            Me._transaction = value
            Dim i As Integer = 0
            Do While (i < Me.CommandCollection.Length)
                Me.CommandCollection(i).Transaction = Me._transaction
                i = (i + 1)
            Loop
            If ((Not (Me.Adapter) Is Nothing)  _
                        AndAlso (Not (Me.Adapter.DeleteCommand) Is Nothing)) Then
                Me.Adapter.DeleteCommand.Transaction = Me._transaction
            End If
            If ((Not (Me.Adapter) Is Nothing)  _
                        AndAlso (Not (Me.Adapter.InsertCommand) Is Nothing)) Then
                Me.Adapter.InsertCommand.Transaction = Me._transaction
            End If
            If ((Not (Me.Adapter) Is Nothing)  _
                        AndAlso (Not (Me.Adapter.UpdateCommand) Is Nothing)) Then
                Me.Adapter.UpdateCommand.Transaction = Me._transaction
            End If
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected ReadOnly Property CommandCollection() As Global.System.Data.SqlClient.SqlCommand()
        Get
            If (Me._commandCollection Is Nothing) Then
                Me.InitCommandCollection
            End If
            Return Me._commandCollection
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Property ClearBeforeFill() As Boolean
        Get
            Return Me._clearBeforeFill
        End Get
        Set
            Me._clearBeforeFill = value
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Sub InitAdapter()
        Me._adapter = New Global.System.Data.SqlClient.SqlDataAdapter()
        Dim tableMapping As Global.System.Data.Common.DataTableMapping = New Global.System.Data.Common.DataTableMapping()
        tableMapping.SourceTable = "Table"
        tableMapping.DataSetTable = "ITT00501_PT_TICKT_MST"
        tableMapping.ColumnMappings.Add("INCDNT_ID", "INCDNT_ID")
        tableMapping.ColumnMappings.Add("SUMM_DESC", "SUMM_DESC")
        tableMapping.ColumnMappings.Add("ASSGN_ID", "ASSGN_ID")
        tableMapping.ColumnMappings.Add("RLATE_TXT", "RLATE_TXT")
        tableMapping.ColumnMappings.Add("NOTE_DESC", "NOTE_DESC")
        tableMapping.ColumnMappings.Add("CMPLT_FLG", "CMPLT_FLG")
        tableMapping.ColumnMappings.Add("FIX_FLG", "FIX_FLG")
        tableMapping.ColumnMappings.Add("CREAT_DTM", "CREAT_DTM")
        tableMapping.ColumnMappings.Add("AUDIT_CREAT_DTM", "AUDIT_CREAT_DTM")
        tableMapping.ColumnMappings.Add("AUDIT_UPDT_DTM", "AUDIT_UPDT_DTM")
        tableMapping.ColumnMappings.Add("AUDIT_HOST_ID", "AUDIT_HOST_ID")
        tableMapping.ColumnMappings.Add("AUDIT_USER_ID", "AUDIT_USER_ID")
        Me._adapter.TableMappings.Add(tableMapping)
        Me._adapter.DeleteCommand = New Global.System.Data.SqlClient.SqlCommand()
        Me._adapter.DeleteCommand.Connection = Me.Connection
        Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[ITT00501_PT_TICKT_MST] WHERE (([INCDNT_ID] = @Original_INCDNT_"& _ 
            "ID) AND ((@IsNull_SUMM_DESC = 1 AND [SUMM_DESC] IS NULL) OR ([SUMM_DESC] = @Orig"& _ 
            "inal_SUMM_DESC)) AND ((@IsNull_ASSGN_ID = 1 AND [ASSGN_ID] IS NULL) OR ([ASSGN_I"& _ 
            "D] = @Original_ASSGN_ID)) AND ((@IsNull_RLATE_TXT = 1 AND [RLATE_TXT] IS NULL) O"& _ 
            "R ([RLATE_TXT] = @Original_RLATE_TXT)) AND ((@IsNull_NOTE_DESC = 1 AND [NOTE_DES"& _ 
            "C] IS NULL) OR ([NOTE_DESC] = @Original_NOTE_DESC)) AND ([CMPLT_FLG] = @Original"& _ 
            "_CMPLT_FLG) AND ([FIX_FLG] = @Original_FIX_FLG) AND ((@IsNull_CREAT_DTM = 1 AND "& _ 
            "[CREAT_DTM] IS NULL) OR ([CREAT_DTM] = @Original_CREAT_DTM)) AND ([AUDIT_CREAT_D"& _ 
            "TM] = @Original_AUDIT_CREAT_DTM) AND ([AUDIT_UPDT_DTM] = @Original_AUDIT_UPDT_DT"& _ 
            "M) AND ([AUDIT_HOST_ID] = @Original_AUDIT_HOST_ID) AND ([AUDIT_USER_ID] = @Origi"& _ 
            "nal_AUDIT_USER_ID))"
        Me._adapter.DeleteCommand.CommandType = Global.System.Data.CommandType.Text
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_INCDNT_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "INCDNT_ID", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_SUMM_DESC", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "SUMM_DESC", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_SUMM_DESC", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "SUMM_DESC", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_ASSGN_ID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ASSGN_ID", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_ASSGN_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ASSGN_ID", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_RLATE_TXT", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "RLATE_TXT", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_RLATE_TXT", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "RLATE_TXT", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_NOTE_DESC", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "NOTE_DESC", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_NOTE_DESC", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "NOTE_DESC", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_CMPLT_FLG", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CMPLT_FLG", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_FIX_FLG", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "FIX_FLG", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_CREAT_DTM", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CREAT_DTM", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_CREAT_DTM", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CREAT_DTM", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_AUDIT_CREAT_DTM", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_CREAT_DTM", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_AUDIT_UPDT_DTM", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_UPDT_DTM", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_AUDIT_HOST_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_HOST_ID", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_AUDIT_USER_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_USER_ID", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.InsertCommand = New Global.System.Data.SqlClient.SqlCommand()
        Me._adapter.InsertCommand.Connection = Me.Connection
        Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[ITT00501_PT_TICKT_MST] ([INCDNT_ID], [SUMM_DESC], [ASSGN_ID], "& _ 
            "[RLATE_TXT], [NOTE_DESC], [CMPLT_FLG], [FIX_FLG], [CREAT_DTM], [AUDIT_CREAT_DTM]"& _ 
            ", [AUDIT_UPDT_DTM], [AUDIT_HOST_ID], [AUDIT_USER_ID]) VALUES (@INCDNT_ID, @SUMM_"& _ 
            "DESC, @ASSGN_ID, @RLATE_TXT, @NOTE_DESC, @CMPLT_FLG, @FIX_FLG, @CREAT_DTM, @AUDI"& _ 
            "T_CREAT_DTM, @AUDIT_UPDT_DTM, @AUDIT_HOST_ID, @AUDIT_USER_ID);"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"SELECT INCDNT_ID"& _ 
            ", SUMM_DESC, ASSGN_ID, RLATE_TXT, NOTE_DESC, CMPLT_FLG, FIX_FLG, CREAT_DTM, AUDI"& _ 
            "T_CREAT_DTM, AUDIT_UPDT_DTM, AUDIT_HOST_ID, AUDIT_USER_ID FROM ITT00501_PT_TICKT"& _ 
            "_MST WHERE (INCDNT_ID = @INCDNT_ID)"
        Me._adapter.InsertCommand.CommandType = Global.System.Data.CommandType.Text
        Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@INCDNT_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "INCDNT_ID", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@SUMM_DESC", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "SUMM_DESC", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@ASSGN_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ASSGN_ID", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@RLATE_TXT", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "RLATE_TXT", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@NOTE_DESC", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "NOTE_DESC", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@CMPLT_FLG", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CMPLT_FLG", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@FIX_FLG", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "FIX_FLG", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@CREAT_DTM", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CREAT_DTM", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@AUDIT_CREAT_DTM", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_CREAT_DTM", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@AUDIT_UPDT_DTM", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_UPDT_DTM", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@AUDIT_HOST_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_HOST_ID", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@AUDIT_USER_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_USER_ID", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand = New Global.System.Data.SqlClient.SqlCommand()
        Me._adapter.UpdateCommand.Connection = Me.Connection
        Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[ITT00501_PT_TICKT_MST] SET [INCDNT_ID] = @INCDNT_ID, [SUMM_DESC] = "& _ 
            "@SUMM_DESC, [ASSGN_ID] = @ASSGN_ID, [RLATE_TXT] = @RLATE_TXT, [NOTE_DESC] = @NOT"& _ 
            "E_DESC, [CMPLT_FLG] = @CMPLT_FLG, [FIX_FLG] = @FIX_FLG, [CREAT_DTM] = @CREAT_DTM"& _ 
            ", [AUDIT_CREAT_DTM] = @AUDIT_CREAT_DTM, [AUDIT_UPDT_DTM] = @AUDIT_UPDT_DTM, [AUD"& _ 
            "IT_HOST_ID] = @AUDIT_HOST_ID, [AUDIT_USER_ID] = @AUDIT_USER_ID WHERE (([INCDNT_I"& _ 
            "D] = @Original_INCDNT_ID) AND ((@IsNull_SUMM_DESC = 1 AND [SUMM_DESC] IS NULL) O"& _ 
            "R ([SUMM_DESC] = @Original_SUMM_DESC)) AND ((@IsNull_ASSGN_ID = 1 AND [ASSGN_ID]"& _ 
            " IS NULL) OR ([ASSGN_ID] = @Original_ASSGN_ID)) AND ((@IsNull_RLATE_TXT = 1 AND "& _ 
            "[RLATE_TXT] IS NULL) OR ([RLATE_TXT] = @Original_RLATE_TXT)) AND ((@IsNull_NOTE_"& _ 
            "DESC = 1 AND [NOTE_DESC] IS NULL) OR ([NOTE_DESC] = @Original_NOTE_DESC)) AND (["& _ 
            "CMPLT_FLG] = @Original_CMPLT_FLG) AND ([FIX_FLG] = @Original_FIX_FLG) AND ((@IsN"& _ 
            "ull_CREAT_DTM = 1 AND [CREAT_DTM] IS NULL) OR ([CREAT_DTM] = @Original_CREAT_DTM"& _ 
            ")) AND ([AUDIT_CREAT_DTM] = @Original_AUDIT_CREAT_DTM) AND ([AUDIT_UPDT_DTM] = @"& _ 
            "Original_AUDIT_UPDT_DTM) AND ([AUDIT_HOST_ID] = @Original_AUDIT_HOST_ID) AND ([A"& _ 
            "UDIT_USER_ID] = @Original_AUDIT_USER_ID));"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"SELECT INCDNT_ID, SUMM_DESC, ASSGN_I"& _ 
            "D, RLATE_TXT, NOTE_DESC, CMPLT_FLG, FIX_FLG, CREAT_DTM, AUDIT_CREAT_DTM, AUDIT_U"& _ 
            "PDT_DTM, AUDIT_HOST_ID, AUDIT_USER_ID FROM ITT00501_PT_TICKT_MST WHERE (INCDNT_I"& _ 
            "D = @INCDNT_ID)"
        Me._adapter.UpdateCommand.CommandType = Global.System.Data.CommandType.Text
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@INCDNT_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "INCDNT_ID", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@SUMM_DESC", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "SUMM_DESC", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@ASSGN_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ASSGN_ID", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@RLATE_TXT", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "RLATE_TXT", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@NOTE_DESC", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "NOTE_DESC", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@CMPLT_FLG", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CMPLT_FLG", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@FIX_FLG", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "FIX_FLG", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@CREAT_DTM", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CREAT_DTM", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@AUDIT_CREAT_DTM", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_CREAT_DTM", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@AUDIT_UPDT_DTM", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_UPDT_DTM", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@AUDIT_HOST_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_HOST_ID", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@AUDIT_USER_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_USER_ID", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_INCDNT_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "INCDNT_ID", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_SUMM_DESC", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "SUMM_DESC", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_SUMM_DESC", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "SUMM_DESC", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_ASSGN_ID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ASSGN_ID", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_ASSGN_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ASSGN_ID", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_RLATE_TXT", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "RLATE_TXT", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_RLATE_TXT", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "RLATE_TXT", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_NOTE_DESC", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "NOTE_DESC", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_NOTE_DESC", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "NOTE_DESC", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_CMPLT_FLG", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CMPLT_FLG", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_FIX_FLG", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "FIX_FLG", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_CREAT_DTM", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CREAT_DTM", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_CREAT_DTM", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CREAT_DTM", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_AUDIT_CREAT_DTM", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_CREAT_DTM", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_AUDIT_UPDT_DTM", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_UPDT_DTM", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_AUDIT_HOST_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_HOST_ID", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
        Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_AUDIT_USER_ID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "AUDIT_USER_ID", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Sub InitConnection()
        Me._connection = New Global.System.Data.SqlClient.SqlConnection()
        Me._connection.ConnectionString = Global.TicketTrack.My.MySettings.Default.dbTicketSQL
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Sub InitCommandCollection()
        Me._commandCollection = New Global.System.Data.SqlClient.SqlCommand(0) {}
        Me._commandCollection(0) = New Global.System.Data.SqlClient.SqlCommand()
        Me._commandCollection(0).Connection = Me.Connection
        Me._commandCollection(0).CommandText = "SELECT INCDNT_ID, SUMM_DESC, ASSGN_ID, RLATE_TXT, NOTE_DESC, CMPLT_FLG, FIX_FLG, "& _ 
            "CREAT_DTM, AUDIT_CREAT_DTM, AUDIT_UPDT_DTM, AUDIT_HOST_ID, AUDIT_USER_ID FROM db"& _ 
            "o.ITT00501_PT_TICKT_MST"
        Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
     Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, true)>  _
    Public Overloads Overridable Function Fill(ByVal dataTable As ITB00500_PT_TICKT_TRACK_APPDataSet.ITT00501_PT_TICKT_MSTDataTable) As Integer
        Me.Adapter.SelectCommand = Me.CommandCollection(0)
        If (Me.ClearBeforeFill = true) Then
            dataTable.Clear
        End If
        Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
        Return returnValue
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
     Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], true)>  _
    Public Overloads Overridable Function GetData() As ITB00500_PT_TICKT_TRACK_APPDataSet.ITT00501_PT_TICKT_MSTDataTable
        Me.Adapter.SelectCommand = Me.CommandCollection(0)
        Dim dataTable As ITB00500_PT_TICKT_TRACK_APPDataSet.ITT00501_PT_TICKT_MSTDataTable = New ITB00500_PT_TICKT_TRACK_APPDataSet.ITT00501_PT_TICKT_MSTDataTable()
        Me.Adapter.Fill(dataTable)
        Return dataTable
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
    Public Overloads Overridable Function Update(ByVal dataTable As ITB00500_PT_TICKT_TRACK_APPDataSet.ITT00501_PT_TICKT_MSTDataTable) As Integer
        Return Me.Adapter.Update(dataTable)
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
    Public Overloads Overridable Function Update(ByVal dataSet As ITB00500_PT_TICKT_TRACK_APPDataSet) As Integer
        Return Me.Adapter.Update(dataSet, "ITT00501_PT_TICKT_MST")
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
    Public Overloads Overridable Function Update(ByVal dataRow As Global.System.Data.DataRow) As Integer
        Return Me.Adapter.Update(New Global.System.Data.DataRow() {dataRow})
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
    Public Overloads Overridable Function Update(ByVal dataRows() As Global.System.Data.DataRow) As Integer
        Return Me.Adapter.Update(dataRows)
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
     Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Delete, true)>  _
    Public Overloads Overridable Function Delete(ByVal Original_INCDNT_ID As String, ByVal Original_SUMM_DESC As String, ByVal Original_ASSGN_ID As String, ByVal Original_RLATE_TXT As String, ByVal Original_NOTE_DESC As String, ByVal Original_CMPLT_FLG As Boolean, ByVal Original_FIX_FLG As Boolean, ByVal Original_CREAT_DTM As Global.System.Nullable(Of Date), ByVal Original_AUDIT_CREAT_DTM As Date, ByVal Original_AUDIT_UPDT_DTM As Date, ByVal Original_AUDIT_HOST_ID As String, ByVal Original_AUDIT_USER_ID As String) As Integer
        If (Original_INCDNT_ID Is Nothing) Then
            Throw New Global.System.ArgumentNullException("Original_INCDNT_ID")
        Else
            Me.Adapter.DeleteCommand.Parameters(0).Value = CType(Original_INCDNT_ID,String)
        End If
        If (Original_SUMM_DESC Is Nothing) Then
            Me.Adapter.DeleteCommand.Parameters(1).Value = CType(1,Object)
            Me.Adapter.DeleteCommand.Parameters(2).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.DeleteCommand.Parameters(1).Value = CType(0,Object)
            Me.Adapter.DeleteCommand.Parameters(2).Value = CType(Original_SUMM_DESC,String)
        End If
        If (Original_ASSGN_ID Is Nothing) Then
            Me.Adapter.DeleteCommand.Parameters(3).Value = CType(1,Object)
            Me.Adapter.DeleteCommand.Parameters(4).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.DeleteCommand.Parameters(3).Value = CType(0,Object)
            Me.Adapter.DeleteCommand.Parameters(4).Value = CType(Original_ASSGN_ID,String)
        End If
        If (Original_RLATE_TXT Is Nothing) Then
            Me.Adapter.DeleteCommand.Parameters(5).Value = CType(1,Object)
            Me.Adapter.DeleteCommand.Parameters(6).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.DeleteCommand.Parameters(5).Value = CType(0,Object)
            Me.Adapter.DeleteCommand.Parameters(6).Value = CType(Original_RLATE_TXT,String)
        End If
        If (Original_NOTE_DESC Is Nothing) Then
            Me.Adapter.DeleteCommand.Parameters(7).Value = CType(1,Object)
            Me.Adapter.DeleteCommand.Parameters(8).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.DeleteCommand.Parameters(7).Value = CType(0,Object)
            Me.Adapter.DeleteCommand.Parameters(8).Value = CType(Original_NOTE_DESC,String)
        End If
        Me.Adapter.DeleteCommand.Parameters(9).Value = CType(Original_CMPLT_FLG,Boolean)
        Me.Adapter.DeleteCommand.Parameters(10).Value = CType(Original_FIX_FLG,Boolean)
        If (Original_CREAT_DTM.HasValue = true) Then
            Me.Adapter.DeleteCommand.Parameters(11).Value = CType(0,Object)
            Me.Adapter.DeleteCommand.Parameters(12).Value = CType(Original_CREAT_DTM.Value,Date)
        Else
            Me.Adapter.DeleteCommand.Parameters(11).Value = CType(1,Object)
            Me.Adapter.DeleteCommand.Parameters(12).Value = Global.System.DBNull.Value
        End If
        Me.Adapter.DeleteCommand.Parameters(13).Value = CType(Original_AUDIT_CREAT_DTM,Date)
        Me.Adapter.DeleteCommand.Parameters(14).Value = CType(Original_AUDIT_UPDT_DTM,Date)
        If (Original_AUDIT_HOST_ID Is Nothing) Then
            Throw New Global.System.ArgumentNullException("Original_AUDIT_HOST_ID")
        Else
            Me.Adapter.DeleteCommand.Parameters(15).Value = CType(Original_AUDIT_HOST_ID,String)
        End If
        If (Original_AUDIT_USER_ID Is Nothing) Then
            Throw New Global.System.ArgumentNullException("Original_AUDIT_USER_ID")
        Else
            Me.Adapter.DeleteCommand.Parameters(16).Value = CType(Original_AUDIT_USER_ID,String)
        End If
        Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.DeleteCommand.Connection.State
        If ((Me.Adapter.DeleteCommand.Connection.State And Global.System.Data.ConnectionState.Open)  _
                    <> Global.System.Data.ConnectionState.Open) Then
            Me.Adapter.DeleteCommand.Connection.Open
        End If
        Try 
            Dim returnValue As Integer = Me.Adapter.DeleteCommand.ExecuteNonQuery
            Return returnValue
        Finally
            If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                Me.Adapter.DeleteCommand.Connection.Close
            End If
        End Try
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
     Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Insert, true)>  _
    Public Overloads Overridable Function Insert(ByVal INCDNT_ID As String, ByVal SUMM_DESC As String, ByVal ASSGN_ID As String, ByVal RLATE_TXT As String, ByVal NOTE_DESC As String, ByVal CMPLT_FLG As Boolean, ByVal FIX_FLG As Boolean, ByVal CREAT_DTM As Global.System.Nullable(Of Date), ByVal AUDIT_CREAT_DTM As Date, ByVal AUDIT_UPDT_DTM As Date, ByVal AUDIT_HOST_ID As String, ByVal AUDIT_USER_ID As String) As Integer
        If (INCDNT_ID Is Nothing) Then
            Throw New Global.System.ArgumentNullException("INCDNT_ID")
        Else
            Me.Adapter.InsertCommand.Parameters(0).Value = CType(INCDNT_ID,String)
        End If
        If (SUMM_DESC Is Nothing) Then
            Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.InsertCommand.Parameters(1).Value = CType(SUMM_DESC,String)
        End If
        If (ASSGN_ID Is Nothing) Then
            Me.Adapter.InsertCommand.Parameters(2).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.InsertCommand.Parameters(2).Value = CType(ASSGN_ID,String)
        End If
        If (RLATE_TXT Is Nothing) Then
            Me.Adapter.InsertCommand.Parameters(3).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.InsertCommand.Parameters(3).Value = CType(RLATE_TXT,String)
        End If
        If (NOTE_DESC Is Nothing) Then
            Me.Adapter.InsertCommand.Parameters(4).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.InsertCommand.Parameters(4).Value = CType(NOTE_DESC,String)
        End If
        Me.Adapter.InsertCommand.Parameters(5).Value = CType(CMPLT_FLG,Boolean)
        Me.Adapter.InsertCommand.Parameters(6).Value = CType(FIX_FLG,Boolean)
        If (CREAT_DTM.HasValue = true) Then
            Me.Adapter.InsertCommand.Parameters(7).Value = CType(CREAT_DTM.Value,Date)
        Else
            Me.Adapter.InsertCommand.Parameters(7).Value = Global.System.DBNull.Value
        End If
        Me.Adapter.InsertCommand.Parameters(8).Value = CType(AUDIT_CREAT_DTM,Date)
        Me.Adapter.InsertCommand.Parameters(9).Value = CType(AUDIT_UPDT_DTM,Date)
        If (AUDIT_HOST_ID Is Nothing) Then
            Throw New Global.System.ArgumentNullException("AUDIT_HOST_ID")
        Else
            Me.Adapter.InsertCommand.Parameters(10).Value = CType(AUDIT_HOST_ID,String)
        End If
        If (AUDIT_USER_ID Is Nothing) Then
            Throw New Global.System.ArgumentNullException("AUDIT_USER_ID")
        Else
            Me.Adapter.InsertCommand.Parameters(11).Value = CType(AUDIT_USER_ID,String)
        End If
        Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
        If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open)  _
                    <> Global.System.Data.ConnectionState.Open) Then
            Me.Adapter.InsertCommand.Connection.Open
        End If
        Try 
            Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery
            Return returnValue
        Finally
            If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                Me.Adapter.InsertCommand.Connection.Close
            End If
        End Try
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
     Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Update, true)>  _
    Public Overloads Overridable Function Update( _
                ByVal INCDNT_ID As String,  _
                ByVal SUMM_DESC As String,  _
                ByVal ASSGN_ID As String,  _
                ByVal RLATE_TXT As String,  _
                ByVal NOTE_DESC As String,  _
                ByVal CMPLT_FLG As Boolean,  _
                ByVal FIX_FLG As Boolean,  _
                ByVal CREAT_DTM As Global.System.Nullable(Of Date),  _
                ByVal AUDIT_CREAT_DTM As Date,  _
                ByVal AUDIT_UPDT_DTM As Date,  _
                ByVal AUDIT_HOST_ID As String,  _
                ByVal AUDIT_USER_ID As String,  _
                ByVal Original_INCDNT_ID As String,  _
                ByVal Original_SUMM_DESC As String,  _
                ByVal Original_ASSGN_ID As String,  _
                ByVal Original_RLATE_TXT As String,  _
                ByVal Original_NOTE_DESC As String,  _
                ByVal Original_CMPLT_FLG As Boolean,  _
                ByVal Original_FIX_FLG As Boolean,  _
                ByVal Original_CREAT_DTM As Global.System.Nullable(Of Date),  _
                ByVal Original_AUDIT_CREAT_DTM As Date,  _
                ByVal Original_AUDIT_UPDT_DTM As Date,  _
                ByVal Original_AUDIT_HOST_ID As String,  _
                ByVal Original_AUDIT_USER_ID As String) As Integer
        If (INCDNT_ID Is Nothing) Then
            Throw New Global.System.ArgumentNullException("INCDNT_ID")
        Else
            Me.Adapter.UpdateCommand.Parameters(0).Value = CType(INCDNT_ID,String)
        End If
        If (SUMM_DESC Is Nothing) Then
            Me.Adapter.UpdateCommand.Parameters(1).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.UpdateCommand.Parameters(1).Value = CType(SUMM_DESC,String)
        End If
        If (ASSGN_ID Is Nothing) Then
            Me.Adapter.UpdateCommand.Parameters(2).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.UpdateCommand.Parameters(2).Value = CType(ASSGN_ID,String)
        End If
        If (RLATE_TXT Is Nothing) Then
            Me.Adapter.UpdateCommand.Parameters(3).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.UpdateCommand.Parameters(3).Value = CType(RLATE_TXT,String)
        End If
        If (NOTE_DESC Is Nothing) Then
            Me.Adapter.UpdateCommand.Parameters(4).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.UpdateCommand.Parameters(4).Value = CType(NOTE_DESC,String)
        End If
        Me.Adapter.UpdateCommand.Parameters(5).Value = CType(CMPLT_FLG,Boolean)
        Me.Adapter.UpdateCommand.Parameters(6).Value = CType(FIX_FLG,Boolean)
        If (CREAT_DTM.HasValue = true) Then
            Me.Adapter.UpdateCommand.Parameters(7).Value = CType(CREAT_DTM.Value,Date)
        Else
            Me.Adapter.UpdateCommand.Parameters(7).Value = Global.System.DBNull.Value
        End If
        Me.Adapter.UpdateCommand.Parameters(8).Value = CType(AUDIT_CREAT_DTM,Date)
        Me.Adapter.UpdateCommand.Parameters(9).Value = CType(AUDIT_UPDT_DTM,Date)
        If (AUDIT_HOST_ID Is Nothing) Then
            Throw New Global.System.ArgumentNullException("AUDIT_HOST_ID")
        Else
            Me.Adapter.UpdateCommand.Parameters(10).Value = CType(AUDIT_HOST_ID,String)
        End If
        If (AUDIT_USER_ID Is Nothing) Then
            Throw New Global.System.ArgumentNullException("AUDIT_USER_ID")
        Else
            Me.Adapter.UpdateCommand.Parameters(11).Value = CType(AUDIT_USER_ID,String)
        End If
        If (Original_INCDNT_ID Is Nothing) Then
            Throw New Global.System.ArgumentNullException("Original_INCDNT_ID")
        Else
            Me.Adapter.UpdateCommand.Parameters(12).Value = CType(Original_INCDNT_ID,String)
        End If
        If (Original_SUMM_DESC Is Nothing) Then
            Me.Adapter.UpdateCommand.Parameters(13).Value = CType(1,Object)
            Me.Adapter.UpdateCommand.Parameters(14).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.UpdateCommand.Parameters(13).Value = CType(0,Object)
            Me.Adapter.UpdateCommand.Parameters(14).Value = CType(Original_SUMM_DESC,String)
        End If
        If (Original_ASSGN_ID Is Nothing) Then
            Me.Adapter.UpdateCommand.Parameters(15).Value = CType(1,Object)
            Me.Adapter.UpdateCommand.Parameters(16).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.UpdateCommand.Parameters(15).Value = CType(0,Object)
            Me.Adapter.UpdateCommand.Parameters(16).Value = CType(Original_ASSGN_ID,String)
        End If
        If (Original_RLATE_TXT Is Nothing) Then
            Me.Adapter.UpdateCommand.Parameters(17).Value = CType(1,Object)
            Me.Adapter.UpdateCommand.Parameters(18).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.UpdateCommand.Parameters(17).Value = CType(0,Object)
            Me.Adapter.UpdateCommand.Parameters(18).Value = CType(Original_RLATE_TXT,String)
        End If
        If (Original_NOTE_DESC Is Nothing) Then
            Me.Adapter.UpdateCommand.Parameters(19).Value = CType(1,Object)
            Me.Adapter.UpdateCommand.Parameters(20).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.UpdateCommand.Parameters(19).Value = CType(0,Object)
            Me.Adapter.UpdateCommand.Parameters(20).Value = CType(Original_NOTE_DESC,String)
        End If
        Me.Adapter.UpdateCommand.Parameters(21).Value = CType(Original_CMPLT_FLG,Boolean)
        Me.Adapter.UpdateCommand.Parameters(22).Value = CType(Original_FIX_FLG,Boolean)
        If (Original_CREAT_DTM.HasValue = true) Then
            Me.Adapter.UpdateCommand.Parameters(23).Value = CType(0,Object)
            Me.Adapter.UpdateCommand.Parameters(24).Value = CType(Original_CREAT_DTM.Value,Date)
        Else
            Me.Adapter.UpdateCommand.Parameters(23).Value = CType(1,Object)
            Me.Adapter.UpdateCommand.Parameters(24).Value = Global.System.DBNull.Value
        End If
        Me.Adapter.UpdateCommand.Parameters(25).Value = CType(Original_AUDIT_CREAT_DTM,Date)
        Me.Adapter.UpdateCommand.Parameters(26).Value = CType(Original_AUDIT_UPDT_DTM,Date)
        If (Original_AUDIT_HOST_ID Is Nothing) Then
            Throw New Global.System.ArgumentNullException("Original_AUDIT_HOST_ID")
        Else
            Me.Adapter.UpdateCommand.Parameters(27).Value = CType(Original_AUDIT_HOST_ID,String)
        End If
        If (Original_AUDIT_USER_ID Is Nothing) Then
            Throw New Global.System.ArgumentNullException("Original_AUDIT_USER_ID")
        Else
            Me.Adapter.UpdateCommand.Parameters(28).Value = CType(Original_AUDIT_USER_ID,String)
        End If
        Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.UpdateCommand.Connection.State
        If ((Me.Adapter.UpdateCommand.Connection.State And Global.System.Data.ConnectionState.Open)  _
                    <> Global.System.Data.ConnectionState.Open) Then
            Me.Adapter.UpdateCommand.Connection.Open
        End If
        Try 
            Dim returnValue As Integer = Me.Adapter.UpdateCommand.ExecuteNonQuery
            Return returnValue
        Finally
            If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                Me.Adapter.UpdateCommand.Connection.Close
            End If
        End Try
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
     Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Update, true)>  _
    Public Overloads Overridable Function Update( _
                ByVal SUMM_DESC As String,  _
                ByVal ASSGN_ID As String,  _
                ByVal RLATE_TXT As String,  _
                ByVal NOTE_DESC As String,  _
                ByVal CMPLT_FLG As Boolean,  _
                ByVal FIX_FLG As Boolean,  _
                ByVal CREAT_DTM As Global.System.Nullable(Of Date),  _
                ByVal AUDIT_CREAT_DTM As Date,  _
                ByVal AUDIT_UPDT_DTM As Date,  _
                ByVal AUDIT_HOST_ID As String,  _
                ByVal AUDIT_USER_ID As String,  _
                ByVal Original_INCDNT_ID As String,  _
                ByVal Original_SUMM_DESC As String,  _
                ByVal Original_ASSGN_ID As String,  _
                ByVal Original_RLATE_TXT As String,  _
                ByVal Original_NOTE_DESC As String,  _
                ByVal Original_CMPLT_FLG As Boolean,  _
                ByVal Original_FIX_FLG As Boolean,  _
                ByVal Original_CREAT_DTM As Global.System.Nullable(Of Date),  _
                ByVal Original_AUDIT_CREAT_DTM As Date,  _
                ByVal Original_AUDIT_UPDT_DTM As Date,  _
                ByVal Original_AUDIT_HOST_ID As String,  _
                ByVal Original_AUDIT_USER_ID As String) As Integer
        Return Me.Update(Original_INCDNT_ID, SUMM_DESC, ASSGN_ID, RLATE_TXT, NOTE_DESC, CMPLT_FLG, FIX_FLG, CREAT_DTM, AUDIT_CREAT_DTM, AUDIT_UPDT_DTM, AUDIT_HOST_ID, AUDIT_USER_ID, Original_INCDNT_ID, Original_SUMM_DESC, Original_ASSGN_ID, Original_RLATE_TXT, Original_NOTE_DESC, Original_CMPLT_FLG, Original_FIX_FLG, Original_CREAT_DTM, Original_AUDIT_CREAT_DTM, Original_AUDIT_UPDT_DTM, Original_AUDIT_HOST_ID, Original_AUDIT_USER_ID)
    End Function
End Class

'''<summary>
'''Represents the connection and commands used to retrieve and save data.
'''</summary>
<Global.System.ComponentModel.DesignerCategoryAttribute("code"),  _
 Global.System.ComponentModel.ToolboxItem(true),  _
 Global.System.ComponentModel.DataObjectAttribute(true),  _
 Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner"& _ 
    ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"),  _
 Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
Partial Public Class ITB00500_PT_TICKT_TRACK_APPDataSetITP00501_PT_TICKT_CHK_CMPLT_GETTableAdapter
    Inherits Global.System.ComponentModel.Component
    
    Private WithEvents _adapter As Global.System.Data.SqlClient.SqlDataAdapter
    
    Private _connection As Global.System.Data.SqlClient.SqlConnection
    
    Private _transaction As Global.System.Data.SqlClient.SqlTransaction
    
    Private _commandCollection() As Global.System.Data.SqlClient.SqlCommand
    
    Private _clearBeforeFill As Boolean
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Sub New()
        MyBase.New
        Me.ClearBeforeFill = true
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Friend ReadOnly Property Adapter() As Global.System.Data.SqlClient.SqlDataAdapter
        Get
            If (Me._adapter Is Nothing) Then
                Me.InitAdapter
            End If
            Return Me._adapter
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Friend Property Connection() As Global.System.Data.SqlClient.SqlConnection
        Get
            If (Me._connection Is Nothing) Then
                Me.InitConnection
            End If
            Return Me._connection
        End Get
        Set
            Me._connection = value
            If (Not (Me.Adapter.InsertCommand) Is Nothing) Then
                Me.Adapter.InsertCommand.Connection = value
            End If
            If (Not (Me.Adapter.DeleteCommand) Is Nothing) Then
                Me.Adapter.DeleteCommand.Connection = value
            End If
            If (Not (Me.Adapter.UpdateCommand) Is Nothing) Then
                Me.Adapter.UpdateCommand.Connection = value
            End If
            Dim i As Integer = 0
            Do While (i < Me.CommandCollection.Length)
                If (Not (Me.CommandCollection(i)) Is Nothing) Then
                    CType(Me.CommandCollection(i),Global.System.Data.SqlClient.SqlCommand).Connection = value
                End If
                i = (i + 1)
            Loop
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Friend Property Transaction() As Global.System.Data.SqlClient.SqlTransaction
        Get
            Return Me._transaction
        End Get
        Set
            Me._transaction = value
            Dim i As Integer = 0
            Do While (i < Me.CommandCollection.Length)
                Me.CommandCollection(i).Transaction = Me._transaction
                i = (i + 1)
            Loop
            If ((Not (Me.Adapter) Is Nothing)  _
                        AndAlso (Not (Me.Adapter.DeleteCommand) Is Nothing)) Then
                Me.Adapter.DeleteCommand.Transaction = Me._transaction
            End If
            If ((Not (Me.Adapter) Is Nothing)  _
                        AndAlso (Not (Me.Adapter.InsertCommand) Is Nothing)) Then
                Me.Adapter.InsertCommand.Transaction = Me._transaction
            End If
            If ((Not (Me.Adapter) Is Nothing)  _
                        AndAlso (Not (Me.Adapter.UpdateCommand) Is Nothing)) Then
                Me.Adapter.UpdateCommand.Transaction = Me._transaction
            End If
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected ReadOnly Property CommandCollection() As Global.System.Data.SqlClient.SqlCommand()
        Get
            If (Me._commandCollection Is Nothing) Then
                Me.InitCommandCollection
            End If
            Return Me._commandCollection
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Property ClearBeforeFill() As Boolean
        Get
            Return Me._clearBeforeFill
        End Get
        Set
            Me._clearBeforeFill = value
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Sub InitAdapter()
        Me._adapter = New Global.System.Data.SqlClient.SqlDataAdapter()
        Dim tableMapping As Global.System.Data.Common.DataTableMapping = New Global.System.Data.Common.DataTableMapping()
        tableMapping.SourceTable = "Table"
        tableMapping.DataSetTable = "ITP00501_PT_TICKT_CHK_CMPLT_GET"
        tableMapping.ColumnMappings.Add("INCDNT_ID", "INCDNT_ID")
        tableMapping.ColumnMappings.Add("SUMM_DESC", "SUMM_DESC")
        tableMapping.ColumnMappings.Add("ASSGN_ID", "ASSGN_ID")
        tableMapping.ColumnMappings.Add("RLATE_TXT", "RLATE_TXT")
        tableMapping.ColumnMappings.Add("NOTE_DESC", "NOTE_DESC")
        tableMapping.ColumnMappings.Add("CMPLT_FLG", "CMPLT_FLG")
        tableMapping.ColumnMappings.Add("FIX_FLG", "FIX_FLG")
        tableMapping.ColumnMappings.Add("CREAT_DTM", "CREAT_DTM")
        Me._adapter.TableMappings.Add(tableMapping)
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Sub InitConnection()
        Me._connection = New Global.System.Data.SqlClient.SqlConnection()
        Me._connection.ConnectionString = Global.TicketTrack.My.MySettings.Default.dbTicketSQL
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Sub InitCommandCollection()
        Me._commandCollection = New Global.System.Data.SqlClient.SqlCommand(0) {}
        Me._commandCollection(0) = New Global.System.Data.SqlClient.SqlCommand()
        Me._commandCollection(0).Connection = Me.Connection
        Me._commandCollection(0).CommandText = "dbo.ITP00501_PT_TICKT_CHK_CMPLT_GET"
        Me._commandCollection(0).CommandType = Global.System.Data.CommandType.StoredProcedure
        Me._commandCollection(0).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@RETURN_VALUE", Global.System.Data.SqlDbType.Int, 4, Global.System.Data.ParameterDirection.ReturnValue, 10, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._commandCollection(0).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@cmplt_flg", Global.System.Data.SqlDbType.Bit, 1, Global.System.Data.ParameterDirection.Input, 1, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._commandCollection(0).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@fix_flg", Global.System.Data.SqlDbType.Bit, 1, Global.System.Data.ParameterDirection.Input, 1, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
     Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, true)>  _
    Public Overloads Overridable Function Fill(ByVal dataTable As ITB00500_PT_TICKT_TRACK_APPDataSet.ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable, ByVal cmplt_flg As Global.System.Nullable(Of Boolean), ByVal fix_flg As Global.System.Nullable(Of Boolean)) As Integer
        Me.Adapter.SelectCommand = Me.CommandCollection(0)
        If (cmplt_flg.HasValue = true) Then
            Me.Adapter.SelectCommand.Parameters(1).Value = CType(cmplt_flg.Value,Boolean)
        Else
            Me.Adapter.SelectCommand.Parameters(1).Value = Global.System.DBNull.Value
        End If
        If (fix_flg.HasValue = true) Then
            Me.Adapter.SelectCommand.Parameters(2).Value = CType(fix_flg.Value,Boolean)
        Else
            Me.Adapter.SelectCommand.Parameters(2).Value = Global.System.DBNull.Value
        End If
        If (Me.ClearBeforeFill = true) Then
            dataTable.Clear
        End If
        Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
        Return returnValue
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
     Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], true)>  _
    Public Overloads Overridable Function GetData(ByVal cmplt_flg As Global.System.Nullable(Of Boolean), ByVal fix_flg As Global.System.Nullable(Of Boolean)) As ITB00500_PT_TICKT_TRACK_APPDataSet.ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable
        Me.Adapter.SelectCommand = Me.CommandCollection(0)
        If (cmplt_flg.HasValue = true) Then
            Me.Adapter.SelectCommand.Parameters(1).Value = CType(cmplt_flg.Value,Boolean)
        Else
            Me.Adapter.SelectCommand.Parameters(1).Value = Global.System.DBNull.Value
        End If
        If (fix_flg.HasValue = true) Then
            Me.Adapter.SelectCommand.Parameters(2).Value = CType(fix_flg.Value,Boolean)
        Else
            Me.Adapter.SelectCommand.Parameters(2).Value = Global.System.DBNull.Value
        End If
        Dim dataTable As ITB00500_PT_TICKT_TRACK_APPDataSet.ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable = New ITB00500_PT_TICKT_TRACK_APPDataSet.ITP00501_PT_TICKT_CHK_CMPLT_GETDataTable()
        Me.Adapter.Fill(dataTable)
        Return dataTable
    End Function
End Class

'''<summary>
'''Represents the connection and commands used to retrieve and save data.
'''</summary>
<Global.System.ComponentModel.DesignerCategoryAttribute("code"),  _
 Global.System.ComponentModel.ToolboxItem(true),  _
 Global.System.ComponentModel.DataObjectAttribute(true),  _
 Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner"& _ 
    ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"),  _
 Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
Partial Public Class ITB00500_PT_TICKT_TRACK_APPDataSetITP00501_PT_TICKT_GETTableAdapter
    Inherits Global.System.ComponentModel.Component
    
    Private WithEvents _adapter As Global.System.Data.SqlClient.SqlDataAdapter
    
    Private _connection As Global.System.Data.SqlClient.SqlConnection
    
    Private _transaction As Global.System.Data.SqlClient.SqlTransaction
    
    Private _commandCollection() As Global.System.Data.SqlClient.SqlCommand
    
    Private _clearBeforeFill As Boolean
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Sub New()
        MyBase.New
        Me.ClearBeforeFill = true
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Friend ReadOnly Property Adapter() As Global.System.Data.SqlClient.SqlDataAdapter
        Get
            If (Me._adapter Is Nothing) Then
                Me.InitAdapter
            End If
            Return Me._adapter
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Friend Property Connection() As Global.System.Data.SqlClient.SqlConnection
        Get
            If (Me._connection Is Nothing) Then
                Me.InitConnection
            End If
            Return Me._connection
        End Get
        Set
            Me._connection = value
            If (Not (Me.Adapter.InsertCommand) Is Nothing) Then
                Me.Adapter.InsertCommand.Connection = value
            End If
            If (Not (Me.Adapter.DeleteCommand) Is Nothing) Then
                Me.Adapter.DeleteCommand.Connection = value
            End If
            If (Not (Me.Adapter.UpdateCommand) Is Nothing) Then
                Me.Adapter.UpdateCommand.Connection = value
            End If
            Dim i As Integer = 0
            Do While (i < Me.CommandCollection.Length)
                If (Not (Me.CommandCollection(i)) Is Nothing) Then
                    CType(Me.CommandCollection(i),Global.System.Data.SqlClient.SqlCommand).Connection = value
                End If
                i = (i + 1)
            Loop
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Friend Property Transaction() As Global.System.Data.SqlClient.SqlTransaction
        Get
            Return Me._transaction
        End Get
        Set
            Me._transaction = value
            Dim i As Integer = 0
            Do While (i < Me.CommandCollection.Length)
                Me.CommandCollection(i).Transaction = Me._transaction
                i = (i + 1)
            Loop
            If ((Not (Me.Adapter) Is Nothing)  _
                        AndAlso (Not (Me.Adapter.DeleteCommand) Is Nothing)) Then
                Me.Adapter.DeleteCommand.Transaction = Me._transaction
            End If
            If ((Not (Me.Adapter) Is Nothing)  _
                        AndAlso (Not (Me.Adapter.InsertCommand) Is Nothing)) Then
                Me.Adapter.InsertCommand.Transaction = Me._transaction
            End If
            If ((Not (Me.Adapter) Is Nothing)  _
                        AndAlso (Not (Me.Adapter.UpdateCommand) Is Nothing)) Then
                Me.Adapter.UpdateCommand.Transaction = Me._transaction
            End If
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected ReadOnly Property CommandCollection() As Global.System.Data.SqlClient.SqlCommand()
        Get
            If (Me._commandCollection Is Nothing) Then
                Me.InitCommandCollection
            End If
            Return Me._commandCollection
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Property ClearBeforeFill() As Boolean
        Get
            Return Me._clearBeforeFill
        End Get
        Set
            Me._clearBeforeFill = value
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Sub InitAdapter()
        Me._adapter = New Global.System.Data.SqlClient.SqlDataAdapter()
        Dim tableMapping As Global.System.Data.Common.DataTableMapping = New Global.System.Data.Common.DataTableMapping()
        tableMapping.SourceTable = "Table"
        tableMapping.DataSetTable = "ITP00501_PT_TICKT_GET"
        tableMapping.ColumnMappings.Add("SUMM_DESC", "SUMM_DESC")
        tableMapping.ColumnMappings.Add("ASSGN_ID", "ASSGN_ID")
        tableMapping.ColumnMappings.Add("RLATE_TXT", "RLATE_TXT")
        tableMapping.ColumnMappings.Add("NOTE_DESC", "NOTE_DESC")
        tableMapping.ColumnMappings.Add("CMPLT_FLG", "CMPLT_FLG")
        tableMapping.ColumnMappings.Add("FIX_FLG", "FIX_FLG")
        tableMapping.ColumnMappings.Add("CREAT_DTM", "CREAT_DTM")
        Me._adapter.TableMappings.Add(tableMapping)
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Sub InitConnection()
        Me._connection = New Global.System.Data.SqlClient.SqlConnection()
        Me._connection.ConnectionString = Global.TicketTrack.My.MySettings.Default.dbTicketSQL
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Sub InitCommandCollection()
        Me._commandCollection = New Global.System.Data.SqlClient.SqlCommand(0) {}
        Me._commandCollection(0) = New Global.System.Data.SqlClient.SqlCommand()
        Me._commandCollection(0).Connection = Me.Connection
        Me._commandCollection(0).CommandText = "dbo.ITP00501_PT_TICKT_GET"
        Me._commandCollection(0).CommandType = Global.System.Data.CommandType.StoredProcedure
        Me._commandCollection(0).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@RETURN_VALUE", Global.System.Data.SqlDbType.Int, 4, Global.System.Data.ParameterDirection.ReturnValue, 10, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._commandCollection(0).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@incdnt_id", Global.System.Data.SqlDbType.VarChar, 20, Global.System.Data.ParameterDirection.Input, 0, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
     Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, true)>  _
    Public Overloads Overridable Function Fill(ByVal dataTable As ITB00500_PT_TICKT_TRACK_APPDataSet.ITP00501_PT_TICKT_GETDataTable, ByVal incdnt_id As String) As Integer
        Me.Adapter.SelectCommand = Me.CommandCollection(0)
        If (incdnt_id Is Nothing) Then
            Me.Adapter.SelectCommand.Parameters(1).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.SelectCommand.Parameters(1).Value = CType(incdnt_id,String)
        End If
        If (Me.ClearBeforeFill = true) Then
            dataTable.Clear
        End If
        Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
        Return returnValue
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
     Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], true)>  _
    Public Overloads Overridable Function GetData(ByVal incdnt_id As String) As ITB00500_PT_TICKT_TRACK_APPDataSet.ITP00501_PT_TICKT_GETDataTable
        Me.Adapter.SelectCommand = Me.CommandCollection(0)
        If (incdnt_id Is Nothing) Then
            Me.Adapter.SelectCommand.Parameters(1).Value = Global.System.DBNull.Value
        Else
            Me.Adapter.SelectCommand.Parameters(1).Value = CType(incdnt_id,String)
        End If
        Dim dataTable As ITB00500_PT_TICKT_TRACK_APPDataSet.ITP00501_PT_TICKT_GETDataTable = New ITB00500_PT_TICKT_TRACK_APPDataSet.ITP00501_PT_TICKT_GETDataTable()
        Me.Adapter.Fill(dataTable)
        Return dataTable
    End Function
End Class

'''<summary>
'''Represents the connection and commands used to retrieve and save data.
'''</summary>
<Global.System.ComponentModel.DesignerCategoryAttribute("code"),  _
 Global.System.ComponentModel.ToolboxItem(true),  _
 Global.System.ComponentModel.DataObjectAttribute(true),  _
 Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner"& _ 
    ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"),  _
 Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
Partial Public Class ITB00500_PT_TICKT_TRACK_APPDataSetQueriesTableAdapter
    Inherits Global.System.ComponentModel.Component
    
    Private _commandCollection() As Global.System.Data.IDbCommand
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected ReadOnly Property CommandCollection() As Global.System.Data.IDbCommand()
        Get
            If (Me._commandCollection Is Nothing) Then
                Me.InitCommandCollection
            End If
            Return Me._commandCollection
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Sub InitCommandCollection()
        Me._commandCollection = New Global.System.Data.IDbCommand(2) {}
        Me._commandCollection(0) = New Global.System.Data.SqlClient.SqlCommand()
        CType(Me._commandCollection(0),Global.System.Data.SqlClient.SqlCommand).Connection = New Global.System.Data.SqlClient.SqlConnection(Global.TicketTrack.My.MySettings.Default.dbTicketSQL)
        CType(Me._commandCollection(0),Global.System.Data.SqlClient.SqlCommand).CommandText = "dbo.ITP00501_PT_TICKT_DEL"
        CType(Me._commandCollection(0),Global.System.Data.SqlClient.SqlCommand).CommandType = Global.System.Data.CommandType.StoredProcedure
        CType(Me._commandCollection(0),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@RETURN_VALUE", Global.System.Data.SqlDbType.Int, 4, Global.System.Data.ParameterDirection.ReturnValue, 10, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(0),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@incdnt_id", Global.System.Data.SqlDbType.VarChar, 20, Global.System.Data.ParameterDirection.Input, 0, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._commandCollection(1) = New Global.System.Data.SqlClient.SqlCommand()
        CType(Me._commandCollection(1),Global.System.Data.SqlClient.SqlCommand).Connection = New Global.System.Data.SqlClient.SqlConnection(Global.TicketTrack.My.MySettings.Default.dbTicketSQL)
        CType(Me._commandCollection(1),Global.System.Data.SqlClient.SqlCommand).CommandText = "dbo.ITP00501_PT_TICKT_INS"
        CType(Me._commandCollection(1),Global.System.Data.SqlClient.SqlCommand).CommandType = Global.System.Data.CommandType.StoredProcedure
        CType(Me._commandCollection(1),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@RETURN_VALUE", Global.System.Data.SqlDbType.Int, 4, Global.System.Data.ParameterDirection.ReturnValue, 10, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(1),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@incdnt_id", Global.System.Data.SqlDbType.VarChar, 20, Global.System.Data.ParameterDirection.Input, 0, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(1),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@summ_desc", Global.System.Data.SqlDbType.VarChar, 100, Global.System.Data.ParameterDirection.Input, 0, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(1),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@assgn_id", Global.System.Data.SqlDbType.VarChar, 100, Global.System.Data.ParameterDirection.Input, 0, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(1),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@rlate_txt", Global.System.Data.SqlDbType.VarChar, 75, Global.System.Data.ParameterDirection.Input, 0, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(1),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@note_desc", Global.System.Data.SqlDbType.VarChar, 200, Global.System.Data.ParameterDirection.Input, 0, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(1),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@cmplt_flg", Global.System.Data.SqlDbType.Bit, 1, Global.System.Data.ParameterDirection.Input, 1, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(1),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@fix_flg", Global.System.Data.SqlDbType.Bit, 1, Global.System.Data.ParameterDirection.Input, 1, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(1),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@creat_dtm", Global.System.Data.SqlDbType.DateTime, 8, Global.System.Data.ParameterDirection.Input, 23, 3, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        Me._commandCollection(2) = New Global.System.Data.SqlClient.SqlCommand()
        CType(Me._commandCollection(2),Global.System.Data.SqlClient.SqlCommand).Connection = New Global.System.Data.SqlClient.SqlConnection(Global.TicketTrack.My.MySettings.Default.dbTicketSQL)
        CType(Me._commandCollection(2),Global.System.Data.SqlClient.SqlCommand).CommandText = "dbo.ITP00501_PT_TICKT_UPD"
        CType(Me._commandCollection(2),Global.System.Data.SqlClient.SqlCommand).CommandType = Global.System.Data.CommandType.StoredProcedure
        CType(Me._commandCollection(2),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@RETURN_VALUE", Global.System.Data.SqlDbType.Int, 4, Global.System.Data.ParameterDirection.ReturnValue, 10, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(2),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@incdnt_id", Global.System.Data.SqlDbType.VarChar, 20, Global.System.Data.ParameterDirection.Input, 0, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(2),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@summ_desc", Global.System.Data.SqlDbType.VarChar, 100, Global.System.Data.ParameterDirection.Input, 0, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(2),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@assgn_id", Global.System.Data.SqlDbType.VarChar, 100, Global.System.Data.ParameterDirection.Input, 0, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(2),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@rlate_txt", Global.System.Data.SqlDbType.VarChar, 75, Global.System.Data.ParameterDirection.Input, 0, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(2),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@note_desc", Global.System.Data.SqlDbType.VarChar, 200, Global.System.Data.ParameterDirection.Input, 0, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(2),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@cmplt_flg", Global.System.Data.SqlDbType.Bit, 1, Global.System.Data.ParameterDirection.Input, 1, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
        CType(Me._commandCollection(2),Global.System.Data.SqlClient.SqlCommand).Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@fix_flg", Global.System.Data.SqlDbType.Bit, 1, Global.System.Data.ParameterDirection.Input, 1, 0, Nothing, Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
    Public Overloads Overridable Function ITP00501_PT_TICKT_DEL(ByVal incdnt_id As String) As Integer
        Dim command As Global.System.Data.SqlClient.SqlCommand = CType(Me.CommandCollection(0),Global.System.Data.SqlClient.SqlCommand)
        If (incdnt_id Is Nothing) Then
            command.Parameters(1).Value = Global.System.DBNull.Value
        Else
            command.Parameters(1).Value = CType(incdnt_id,String)
        End If
        Dim previousConnectionState As Global.System.Data.ConnectionState = command.Connection.State
        If ((command.Connection.State And Global.System.Data.ConnectionState.Open)  _
                    <> Global.System.Data.ConnectionState.Open) Then
            command.Connection.Open
        End If
        Dim returnValue As Integer
        Try 
            returnValue = command.ExecuteNonQuery
        Finally
            If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                command.Connection.Close
            End If
        End Try
        Return returnValue
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
    Public Overloads Overridable Function ITP00501_PT_TICKT_INS(ByVal incdnt_id As String, ByVal summ_desc As String, ByVal assgn_id As String, ByVal rlate_txt As String, ByVal note_desc As String, ByVal cmplt_flg As Global.System.Nullable(Of Boolean), ByVal fix_flg As Global.System.Nullable(Of Boolean), ByVal creat_dtm As Global.System.Nullable(Of Date)) As Integer
        Dim command As Global.System.Data.SqlClient.SqlCommand = CType(Me.CommandCollection(1),Global.System.Data.SqlClient.SqlCommand)
        If (incdnt_id Is Nothing) Then
            command.Parameters(1).Value = Global.System.DBNull.Value
        Else
            command.Parameters(1).Value = CType(incdnt_id,String)
        End If
        If (summ_desc Is Nothing) Then
            command.Parameters(2).Value = Global.System.DBNull.Value
        Else
            command.Parameters(2).Value = CType(summ_desc,String)
        End If
        If (assgn_id Is Nothing) Then
            command.Parameters(3).Value = Global.System.DBNull.Value
        Else
            command.Parameters(3).Value = CType(assgn_id,String)
        End If
        If (rlate_txt Is Nothing) Then
            command.Parameters(4).Value = Global.System.DBNull.Value
        Else
            command.Parameters(4).Value = CType(rlate_txt,String)
        End If
        If (note_desc Is Nothing) Then
            command.Parameters(5).Value = Global.System.DBNull.Value
        Else
            command.Parameters(5).Value = CType(note_desc,String)
        End If
        If (cmplt_flg.HasValue = true) Then
            command.Parameters(6).Value = CType(cmplt_flg.Value,Boolean)
        Else
            command.Parameters(6).Value = Global.System.DBNull.Value
        End If
        If (fix_flg.HasValue = true) Then
            command.Parameters(7).Value = CType(fix_flg.Value,Boolean)
        Else
            command.Parameters(7).Value = Global.System.DBNull.Value
        End If
        If (creat_dtm.HasValue = true) Then
            command.Parameters(8).Value = CType(creat_dtm.Value,Date)
        Else
            command.Parameters(8).Value = Global.System.DBNull.Value
        End If
        Dim previousConnectionState As Global.System.Data.ConnectionState = command.Connection.State
        If ((command.Connection.State And Global.System.Data.ConnectionState.Open)  _
                    <> Global.System.Data.ConnectionState.Open) Then
            command.Connection.Open
        End If
        Dim returnValue As Integer
        Try 
            returnValue = command.ExecuteNonQuery
        Finally
            If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                command.Connection.Close
            End If
        End Try
        Return returnValue
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
    Public Overloads Overridable Function ITP00501_PT_TICKT_UPD(ByVal incdnt_id As String, ByVal summ_desc As String, ByVal assgn_id As String, ByVal rlate_txt As String, ByVal note_desc As String, ByVal cmplt_flg As Global.System.Nullable(Of Boolean), ByVal fix_flg As Global.System.Nullable(Of Boolean)) As Integer
        Dim command As Global.System.Data.SqlClient.SqlCommand = CType(Me.CommandCollection(2),Global.System.Data.SqlClient.SqlCommand)
        If (incdnt_id Is Nothing) Then
            command.Parameters(1).Value = Global.System.DBNull.Value
        Else
            command.Parameters(1).Value = CType(incdnt_id,String)
        End If
        If (summ_desc Is Nothing) Then
            command.Parameters(2).Value = Global.System.DBNull.Value
        Else
            command.Parameters(2).Value = CType(summ_desc,String)
        End If
        If (assgn_id Is Nothing) Then
            command.Parameters(3).Value = Global.System.DBNull.Value
        Else
            command.Parameters(3).Value = CType(assgn_id,String)
        End If
        If (rlate_txt Is Nothing) Then
            command.Parameters(4).Value = Global.System.DBNull.Value
        Else
            command.Parameters(4).Value = CType(rlate_txt,String)
        End If
        If (note_desc Is Nothing) Then
            command.Parameters(5).Value = Global.System.DBNull.Value
        Else
            command.Parameters(5).Value = CType(note_desc,String)
        End If
        If (cmplt_flg.HasValue = true) Then
            command.Parameters(6).Value = CType(cmplt_flg.Value,Boolean)
        Else
            command.Parameters(6).Value = Global.System.DBNull.Value
        End If
        If (fix_flg.HasValue = true) Then
            command.Parameters(7).Value = CType(fix_flg.Value,Boolean)
        Else
            command.Parameters(7).Value = Global.System.DBNull.Value
        End If
        Dim previousConnectionState As Global.System.Data.ConnectionState = command.Connection.State
        If ((command.Connection.State And Global.System.Data.ConnectionState.Open)  _
                    <> Global.System.Data.ConnectionState.Open) Then
            command.Connection.Open
        End If
        Dim returnValue As Integer
        Try 
            returnValue = command.ExecuteNonQuery
        Finally
            If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
                command.Connection.Close
            End If
        End Try
        Return returnValue
    End Function
End Class

'''<summary>
'''TableAdapterManager is used to coordinate TableAdapters in the dataset to enable Hierarchical Update scenarios
'''</summary>
<Global.System.ComponentModel.DesignerCategoryAttribute("code"),  _
 Global.System.ComponentModel.ToolboxItem(true),  _
 Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSD"& _ 
    "esigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"),  _
 Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapterManager")>  _
Partial Public Class ITB00500_PT_TICKT_TRACK_APPDataSetTableAdapterManager
    Inherits Global.System.ComponentModel.Component
    
    Private _updateOrder As UpdateOrderOption
    
    Private _iTT00501_PT_TICKT_MSTTableAdapter As ITT00501_PT_TICKT_MSTTableAdapter
    
    Private _backupDataSetBeforeUpdate As Boolean
    
    Private _connection As Global.System.Data.IDbConnection
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Property UpdateOrder() As UpdateOrderOption
        Get
            Return Me._updateOrder
        End Get
        Set
            Me._updateOrder = value
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso"& _ 
        "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3"& _ 
        "a", "System.Drawing.Design.UITypeEditor")>  _
    Public Property ITT00501_PT_TICKT_MSTTableAdapter() As ITT00501_PT_TICKT_MSTTableAdapter
        Get
            Return Me._iTT00501_PT_TICKT_MSTTableAdapter
        End Get
        Set
            Me._iTT00501_PT_TICKT_MSTTableAdapter = value
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Property BackupDataSetBeforeUpdate() As Boolean
        Get
            Return Me._backupDataSetBeforeUpdate
        End Get
        Set
            Me._backupDataSetBeforeUpdate = value
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Browsable(false)>  _
    Public Property Connection() As Global.System.Data.IDbConnection
        Get
            If (Not (Me._connection) Is Nothing) Then
                Return Me._connection
            End If
            If ((Not (Me._iTT00501_PT_TICKT_MSTTableAdapter) Is Nothing)  _
                        AndAlso (Not (Me._iTT00501_PT_TICKT_MSTTableAdapter.Connection) Is Nothing)) Then
                Return Me._iTT00501_PT_TICKT_MSTTableAdapter.Connection
            End If
            Return Nothing
        End Get
        Set
            Me._connection = value
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"),  _
     Global.System.ComponentModel.Browsable(false)>  _
    Public ReadOnly Property TableAdapterInstanceCount() As Integer
        Get
            Dim count As Integer = 0
            If (Not (Me._iTT00501_PT_TICKT_MSTTableAdapter) Is Nothing) Then
                count = (count + 1)
            End If
            Return count
        End Get
    End Property
    
    '''<summary>
    '''Update rows in top-down order.
    '''</summary>
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Function UpdateUpdatedRows(ByVal dataSet As ITB00500_PT_TICKT_TRACK_APPDataSet, ByVal allChangedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow), ByVal allAddedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)) As Integer
        Dim result As Integer = 0
        If (Not (Me._iTT00501_PT_TICKT_MSTTableAdapter) Is Nothing) Then
            Dim updatedRows() As Global.System.Data.DataRow = dataSet.ITT00501_PT_TICKT_MST.Select(Nothing, Nothing, Global.System.Data.DataViewRowState.ModifiedCurrent)
            updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
            If ((Not (updatedRows) Is Nothing)  _
                        AndAlso (0 < updatedRows.Length)) Then
                result = (result + Me._iTT00501_PT_TICKT_MSTTableAdapter.Update(updatedRows))
                allChangedRows.AddRange(updatedRows)
            End If
        End If
        Return result
    End Function
    
    '''<summary>
    '''Insert rows in top-down order.
    '''</summary>
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Function UpdateInsertedRows(ByVal dataSet As ITB00500_PT_TICKT_TRACK_APPDataSet, ByVal allAddedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)) As Integer
        Dim result As Integer = 0
        If (Not (Me._iTT00501_PT_TICKT_MSTTableAdapter) Is Nothing) Then
            Dim addedRows() As Global.System.Data.DataRow = dataSet.ITT00501_PT_TICKT_MST.Select(Nothing, Nothing, Global.System.Data.DataViewRowState.Added)
            If ((Not (addedRows) Is Nothing)  _
                        AndAlso (0 < addedRows.Length)) Then
                result = (result + Me._iTT00501_PT_TICKT_MSTTableAdapter.Update(addedRows))
                allAddedRows.AddRange(addedRows)
            End If
        End If
        Return result
    End Function
    
    '''<summary>
    '''Delete rows in bottom-up order.
    '''</summary>
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Function UpdateDeletedRows(ByVal dataSet As ITB00500_PT_TICKT_TRACK_APPDataSet, ByVal allChangedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)) As Integer
        Dim result As Integer = 0
        If (Not (Me._iTT00501_PT_TICKT_MSTTableAdapter) Is Nothing) Then
            Dim deletedRows() As Global.System.Data.DataRow = dataSet.ITT00501_PT_TICKT_MST.Select(Nothing, Nothing, Global.System.Data.DataViewRowState.Deleted)
            If ((Not (deletedRows) Is Nothing)  _
                        AndAlso (0 < deletedRows.Length)) Then
                result = (result + Me._iTT00501_PT_TICKT_MSTTableAdapter.Update(deletedRows))
                allChangedRows.AddRange(deletedRows)
            End If
        End If
        Return result
    End Function
    
    '''<summary>
    '''Remove inserted rows that become updated rows after calling TableAdapter.Update(inserted rows) first
    '''</summary>
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Function GetRealUpdatedRows(ByVal updatedRows() As Global.System.Data.DataRow, ByVal allAddedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)) As Global.System.Data.DataRow()
        If ((updatedRows Is Nothing)  _
                    OrElse (updatedRows.Length < 1)) Then
            Return updatedRows
        End If
        If ((allAddedRows Is Nothing)  _
                    OrElse (allAddedRows.Count < 1)) Then
            Return updatedRows
        End If
        Dim realUpdatedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow) = New Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)()
        Dim i As Integer = 0
        Do While (i < updatedRows.Length)
            Dim row As Global.System.Data.DataRow = updatedRows(i)
            If (allAddedRows.Contains(row) = false) Then
                realUpdatedRows.Add(row)
            End If
            i = (i + 1)
        Loop
        Return realUpdatedRows.ToArray
    End Function
    
    '''<summary>
    '''Update all changes to the dataset.
    '''</summary>
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Overridable Function UpdateAll(ByVal dataSet As ITB00500_PT_TICKT_TRACK_APPDataSet) As Integer
        If (dataSet Is Nothing) Then
            Throw New Global.System.ArgumentNullException("dataSet")
        End If
        If (dataSet.HasChanges = false) Then
            Return 0
        End If
        If ((Not (Me._iTT00501_PT_TICKT_MSTTableAdapter) Is Nothing)  _
                    AndAlso (Me.MatchTableAdapterConnection(Me._iTT00501_PT_TICKT_MSTTableAdapter.Connection) = false)) Then
            Throw New Global.System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s"& _ 
                    "tring.")
        End If
        Dim workConnection As Global.System.Data.IDbConnection = Me.Connection
        If (workConnection Is Nothing) Then
            Throw New Global.System.ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterMana"& _ 
                    "ger TableAdapter property to a valid TableAdapter instance.")
        End If
        Dim workConnOpened As Boolean = false
        If ((workConnection.State And Global.System.Data.ConnectionState.Broken)  _
                    = Global.System.Data.ConnectionState.Broken) Then
            workConnection.Close
        End If
        If (workConnection.State = Global.System.Data.ConnectionState.Closed) Then
            workConnection.Open
            workConnOpened = true
        End If
        Dim workTransaction As Global.System.Data.IDbTransaction = workConnection.BeginTransaction
        If (workTransaction Is Nothing) Then
            Throw New Global.System.ApplicationException("The transaction cannot begin. The current data connection does not support transa"& _ 
                    "ctions or the current state is not allowing the transaction to begin.")
        End If
        Dim allChangedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow) = New Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)()
        Dim allAddedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow) = New Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)()
        Dim adaptersWithAcceptChangesDuringUpdate As Global.System.Collections.Generic.List(Of Global.System.Data.Common.DataAdapter) = New Global.System.Collections.Generic.List(Of Global.System.Data.Common.DataAdapter)()
        Dim revertConnections As Global.System.Collections.Generic.Dictionary(Of Object, Global.System.Data.IDbConnection) = New Global.System.Collections.Generic.Dictionary(Of Object, Global.System.Data.IDbConnection)()
        Dim result As Integer = 0
        Dim backupDataSet As Global.System.Data.DataSet = Nothing
        If Me.BackupDataSetBeforeUpdate Then
            backupDataSet = New Global.System.Data.DataSet()
            backupDataSet.Merge(dataSet)
        End If
        Try 
            '---- Prepare for update -----------
            '
            If (Not (Me._iTT00501_PT_TICKT_MSTTableAdapter) Is Nothing) Then
                revertConnections.Add(Me._iTT00501_PT_TICKT_MSTTableAdapter, Me._iTT00501_PT_TICKT_MSTTableAdapter.Connection)
                Me._iTT00501_PT_TICKT_MSTTableAdapter.Connection = CType(workConnection,Global.System.Data.SqlClient.SqlConnection)
                Me._iTT00501_PT_TICKT_MSTTableAdapter.Transaction = CType(workTransaction,Global.System.Data.SqlClient.SqlTransaction)
                If Me._iTT00501_PT_TICKT_MSTTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                    Me._iTT00501_PT_TICKT_MSTTableAdapter.Adapter.AcceptChangesDuringUpdate = false
                    adaptersWithAcceptChangesDuringUpdate.Add(Me._iTT00501_PT_TICKT_MSTTableAdapter.Adapter)
                End If
            End If
            '
            '---- Perform updates -----------
            '
            If (Me.UpdateOrder = UpdateOrderOption.UpdateInsertDelete) Then
                result = (result + Me.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows))
                result = (result + Me.UpdateInsertedRows(dataSet, allAddedRows))
            Else
                result = (result + Me.UpdateInsertedRows(dataSet, allAddedRows))
                result = (result + Me.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows))
            End If
            result = (result + Me.UpdateDeletedRows(dataSet, allChangedRows))
            '
            '---- Commit updates -----------
            '
            workTransaction.Commit
            If (0 < allAddedRows.Count) Then
                Dim rows((allAddedRows.Count) - 1) As Global.System.Data.DataRow
                allAddedRows.CopyTo(rows)
                Dim i As Integer = 0
                Do While (i < rows.Length)
                    Dim row As Global.System.Data.DataRow = rows(i)
                    row.AcceptChanges
                    i = (i + 1)
                Loop
            End If
            If (0 < allChangedRows.Count) Then
                Dim rows((allChangedRows.Count) - 1) As Global.System.Data.DataRow
                allChangedRows.CopyTo(rows)
                Dim i As Integer = 0
                Do While (i < rows.Length)
                    Dim row As Global.System.Data.DataRow = rows(i)
                    row.AcceptChanges
                    i = (i + 1)
                Loop
            End If
        Catch ex As Global.System.Exception
            workTransaction.Rollback
            '---- Restore the dataset -----------
            If Me.BackupDataSetBeforeUpdate Then
                Global.System.Diagnostics.Debug.Assert((Not (backupDataSet) Is Nothing))
                dataSet.Clear
                dataSet.Merge(backupDataSet)
            Else
                If (0 < allAddedRows.Count) Then
                    Dim rows((allAddedRows.Count) - 1) As Global.System.Data.DataRow
                    allAddedRows.CopyTo(rows)
                    Dim i As Integer = 0
                    Do While (i < rows.Length)
                        Dim row As Global.System.Data.DataRow = rows(i)
                        row.AcceptChanges
                        row.SetAdded
                        i = (i + 1)
                    Loop
                End If
            End If
            Throw ex
        Finally
            If workConnOpened Then
                workConnection.Close
            End If
            If (Not (Me._iTT00501_PT_TICKT_MSTTableAdapter) Is Nothing) Then
                Me._iTT00501_PT_TICKT_MSTTableAdapter.Connection = CType(revertConnections(Me._iTT00501_PT_TICKT_MSTTableAdapter),Global.System.Data.SqlClient.SqlConnection)
                Me._iTT00501_PT_TICKT_MSTTableAdapter.Transaction = Nothing
            End If
            If (0 < adaptersWithAcceptChangesDuringUpdate.Count) Then
                Dim adapters((adaptersWithAcceptChangesDuringUpdate.Count) - 1) As Global.System.Data.Common.DataAdapter
                adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters)
                Dim i As Integer = 0
                Do While (i < adapters.Length)
                    Dim adapter As Global.System.Data.Common.DataAdapter = adapters(i)
                    adapter.AcceptChangesDuringUpdate = true
                    i = (i + 1)
                Loop
            End If
        End Try
        Return result
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Overridable Sub SortSelfReferenceRows(ByVal rows() As Global.System.Data.DataRow, ByVal relation As Global.System.Data.DataRelation, ByVal childFirst As Boolean)
        Global.System.Array.Sort(Of Global.System.Data.DataRow)(rows, New SelfReferenceComparer(relation, childFirst))
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Protected Overridable Function MatchTableAdapterConnection(ByVal inputConnection As Global.System.Data.IDbConnection) As Boolean
        If (Not (Me._connection) Is Nothing) Then
            Return true
        End If
        If ((Me.Connection Is Nothing)  _
                    OrElse (inputConnection Is Nothing)) Then
            Return true
        End If
        If String.Equals(Me.Connection.ConnectionString, inputConnection.ConnectionString, Global.System.StringComparison.Ordinal) Then
            Return true
        End If
        Return false
    End Function
    
    '''<summary>
    '''Update Order Option
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Public Enum UpdateOrderOption
        
        InsertUpdateDelete = 0
        
        UpdateInsertDelete = 1
    End Enum
    
    '''<summary>
    '''Used to sort self-referenced table's rows
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
    Private Class SelfReferenceComparer
        Inherits Object
        Implements Global.System.Collections.Generic.IComparer(Of Global.System.Data.DataRow)
        
        Private _relation As Global.System.Data.DataRelation
        
        Private _childFirst As Integer
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Friend Sub New(ByVal relation As Global.System.Data.DataRelation, ByVal childFirst As Boolean)
            MyBase.New
            Me._relation = relation
            If childFirst Then
                Me._childFirst = -1
            Else
                Me._childFirst = 1
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Private Function GetRoot(ByVal row As Global.System.Data.DataRow, ByRef distance As Integer) As Global.System.Data.DataRow
            Global.System.Diagnostics.Debug.Assert((Not (row) Is Nothing))
            Dim root As Global.System.Data.DataRow = row
            distance = 0

            Dim traversedRows As Global.System.Collections.Generic.IDictionary(Of Global.System.Data.DataRow, Global.System.Data.DataRow) = New Global.System.Collections.Generic.Dictionary(Of Global.System.Data.DataRow, Global.System.Data.DataRow)()
            traversedRows(row) = row

            Dim parent As Global.System.Data.DataRow = row.GetParentRow(Me._relation, Global.System.Data.DataRowVersion.[Default])

            Do While ((Not (parent) Is Nothing)  _
                        AndAlso (traversedRows.ContainsKey(parent) = false))
                distance = (distance + 1)
                root = parent
                traversedRows(parent) = parent
                parent = parent.GetParentRow(Me._relation, Global.System.Data.DataRowVersion.[Default])

            Loop

            If (distance = 0) Then
                traversedRows.Clear
                traversedRows(row) = row
                parent = row.GetParentRow(Me._relation, Global.System.Data.DataRowVersion.Original)

                Do While ((Not (parent) Is Nothing)  _
                            AndAlso (traversedRows.ContainsKey(parent) = false))
                    distance = (distance + 1)
                    root = parent
                    traversedRows(parent) = parent
                    parent = parent.GetParentRow(Me._relation, Global.System.Data.DataRowVersion.Original)

                Loop
            End If

            Return root
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>  _
        Public Function Compare(ByVal row1 As Global.System.Data.DataRow, ByVal row2 As Global.System.Data.DataRow) As Integer Implements Global.System.Collections.Generic.IComparer(Of Global.System.Data.DataRow).Compare
            If Object.ReferenceEquals(row1, row2) Then
                Return 0
            End If
            If (row1 Is Nothing) Then
                Return -1
            End If
            If (row2 Is Nothing) Then
                Return 1
            End If

            Dim distance1 As Integer = 0
            Dim root1 As Global.System.Data.DataRow = Me.GetRoot(row1, distance1)

            Dim distance2 As Integer = 0
            Dim root2 As Global.System.Data.DataRow = Me.GetRoot(row2, distance2)

            If Object.ReferenceEquals(root1, root2) Then
                Return (Me._childFirst * distance1.CompareTo(distance2))
            Else
                Global.System.Diagnostics.Debug.Assert(((Not (root1.Table) Is Nothing)  _
                                AndAlso (Not (root2.Table) Is Nothing)))
                If (root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2)) Then
                    Return -1
                Else
                    Return 1
                End If
            End If
        End Function
    End Class
End Class
