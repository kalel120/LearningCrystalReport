﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#pragma warning disable 1591

namespace Dataedge.Report.LearningCrystalReport {
    
    
    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [Serializable()]
    [DesignerCategory("code")]
    [ToolboxItem(true)]
    [XmlSchemaProvider("GetTypedDataSetSchema")]
    [XmlRoot("dsSample")]
    [HelpKeyword("vs.data.DataSet")]
    public partial class dsSample : DataSet {
        
        private DataTable1DataTable tableDataTable1;
        
        private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public dsSample() {
            this.BeginInit();
            this.InitClass();
            CollectionChangeEventHandler schemaChangedHandler = new CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected dsSample(SerializationInfo info, StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                CollectionChangeEventHandler schemaChangedHandler1 = new CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new StringReader(strSchema)));
                if ((ds.Tables["DataTable1"] != null)) {
                    base.Tables.Add(new DataTable1DataTable(ds.Tables["DataTable1"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new XmlTextReader(new StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            CollectionChangeEventHandler schemaChangedHandler = new CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable1DataTable DataTable1 {
            get {
                return this.tableDataTable1;
            }
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override DataSet Clone() {
            dsSample cln = ((dsSample)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void ReadXmlSerializable(XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                DataSet ds = new DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["DataTable1"] != null)) {
                    base.Tables.Add(new DataTable1DataTable(ds.Tables["DataTable1"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override XmlSchema GetSchemaSerializable() {
            MemoryStream stream = new MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars(bool initTable) {
            this.tableDataTable1 = ((DataTable1DataTable)(base.Tables["DataTable1"]));
            if ((initTable == true)) {
                if ((this.tableDataTable1 != null)) {
                    this.tableDataTable1.InitVars();
                }
            }
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass() {
            this.DataSetName = "dsSample";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/dsSample.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.tableDataTable1 = new DataTable1DataTable();
            base.Tables.Add(this.tableDataTable1);
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeDataTable1() {
            return false;
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void SchemaChanged(object sender, CollectionChangeEventArgs e) {
            if ((e.Action == CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [DebuggerNonUserCode()]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs) {
            dsSample ds = new dsSample();
            XmlSchemaComplexType type = new XmlSchemaComplexType();
            XmlSchemaSequence sequence = new XmlSchemaSequence();
            XmlSchemaAny any = new XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                MemoryStream s1 = new MemoryStream();
                MemoryStream s2 = new MemoryStream();
                try {
                    XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
        
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void DataTable1RowChangeEventHandler(object sender, DataTable1RowChangeEvent e);
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [Serializable()]
        [XmlSchemaProvider("GetTypedTableSchema")]
        public partial class DataTable1DataTable : TypedTableBase<DataTable1Row> {
            
            private DataColumn columnCustomer_Name;
            
            private DataColumn columnOrder_ID;
            
            private DataColumn columnProduct_Name;
            
            private DataColumn columnProduct_Qty;
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataTable1DataTable() {
                this.TableName = "DataTable1";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal DataTable1DataTable(DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected DataTable1DataTable(SerializationInfo info, StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Customer_NameColumn {
                get {
                    return this.columnCustomer_Name;
                }
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Order_IDColumn {
                get {
                    return this.columnOrder_ID;
                }
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Product_NameColumn {
                get {
                    return this.columnProduct_Name;
                }
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn Product_QtyColumn {
                get {
                    return this.columnProduct_Qty;
                }
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataTable1Row this[int index] {
                get {
                    return ((DataTable1Row)(this.Rows[index]));
                }
            }
            
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event DataTable1RowChangeEventHandler DataTable1RowChanging;
            
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event DataTable1RowChangeEventHandler DataTable1RowChanged;
            
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event DataTable1RowChangeEventHandler DataTable1RowDeleting;
            
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event DataTable1RowChangeEventHandler DataTable1RowDeleted;
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddDataTable1Row(DataTable1Row row) {
                this.Rows.Add(row);
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataTable1Row AddDataTable1Row(string Customer_Name, int Order_ID, string Product_Name, int Product_Qty) {
                DataTable1Row rowDataTable1Row = ((DataTable1Row)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        Customer_Name,
                        Order_ID,
                        Product_Name,
                        Product_Qty};
                rowDataTable1Row.ItemArray = columnValuesArray;
                this.Rows.Add(rowDataTable1Row);
                return rowDataTable1Row;
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone() {
                DataTable1DataTable cln = ((DataTable1DataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance() {
                return new DataTable1DataTable();
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars() {
                this.columnCustomer_Name = base.Columns["Customer_Name"];
                this.columnOrder_ID = base.Columns["Order_ID"];
                this.columnProduct_Name = base.Columns["Product_Name"];
                this.columnProduct_Qty = base.Columns["Product_Qty"];
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass() {
                this.columnCustomer_Name = new DataColumn("Customer_Name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnCustomer_Name);
                this.columnOrder_ID = new DataColumn("Order_ID", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnOrder_ID);
                this.columnProduct_Name = new DataColumn("Product_Name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnProduct_Name);
                this.columnProduct_Qty = new DataColumn("Product_Qty", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnProduct_Qty);
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataTable1Row NewDataTable1Row() {
                return ((DataTable1Row)(this.NewRow()));
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new DataTable1Row(builder);
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType() {
                return typeof(DataTable1Row);
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.DataTable1RowChanged != null)) {
                    this.DataTable1RowChanged(this, new DataTable1RowChangeEvent(((DataTable1Row)(e.Row)), e.Action));
                }
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.DataTable1RowChanging != null)) {
                    this.DataTable1RowChanging(this, new DataTable1RowChangeEvent(((DataTable1Row)(e.Row)), e.Action));
                }
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.DataTable1RowDeleted != null)) {
                    this.DataTable1RowDeleted(this, new DataTable1RowChangeEvent(((DataTable1Row)(e.Row)), e.Action));
                }
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.DataTable1RowDeleting != null)) {
                    this.DataTable1RowDeleting(this, new DataTable1RowChangeEvent(((DataTable1Row)(e.Row)), e.Action));
                }
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveDataTable1Row(DataTable1Row row) {
                this.Rows.Remove(row);
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs) {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                dsSample ds = new dsSample();
                XmlSchemaAny any1 = new XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                XmlSchemaAny any2 = new XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute1 = new XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "DataTable1DataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    MemoryStream s1 = new MemoryStream();
                    MemoryStream s2 = new MemoryStream();
                    try {
                        XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class DataTable1Row : DataRow {
            
            private DataTable1DataTable tableDataTable1;
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal DataTable1Row(DataRowBuilder rb) : 
                    base(rb) {
                this.tableDataTable1 = ((DataTable1DataTable)(this.Table));
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Customer_Name {
                get {
                    try {
                        return ((string)(this[this.tableDataTable1.Customer_NameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("The value for column \'Customer_Name\' in table \'DataTable1\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDataTable1.Customer_NameColumn] = value;
                }
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Order_ID {
                get {
                    try {
                        return ((int)(this[this.tableDataTable1.Order_IDColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("The value for column \'Order_ID\' in table \'DataTable1\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDataTable1.Order_IDColumn] = value;
                }
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Product_Name {
                get {
                    try {
                        return ((string)(this[this.tableDataTable1.Product_NameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("The value for column \'Product_Name\' in table \'DataTable1\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDataTable1.Product_NameColumn] = value;
                }
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Product_Qty {
                get {
                    try {
                        return ((int)(this[this.tableDataTable1.Product_QtyColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("The value for column \'Product_Qty\' in table \'DataTable1\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDataTable1.Product_QtyColumn] = value;
                }
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCustomer_NameNull() {
                return this.IsNull(this.tableDataTable1.Customer_NameColumn);
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCustomer_NameNull() {
                this[this.tableDataTable1.Customer_NameColumn] = Convert.DBNull;
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsOrder_IDNull() {
                return this.IsNull(this.tableDataTable1.Order_IDColumn);
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetOrder_IDNull() {
                this[this.tableDataTable1.Order_IDColumn] = Convert.DBNull;
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsProduct_NameNull() {
                return this.IsNull(this.tableDataTable1.Product_NameColumn);
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetProduct_NameNull() {
                this[this.tableDataTable1.Product_NameColumn] = Convert.DBNull;
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsProduct_QtyNull() {
                return this.IsNull(this.tableDataTable1.Product_QtyColumn);
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetProduct_QtyNull() {
                this[this.tableDataTable1.Product_QtyColumn] = Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class DataTable1RowChangeEvent : EventArgs {
            
            private DataTable1Row eventRow;
            
            private DataRowAction eventAction;
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataTable1RowChangeEvent(DataTable1Row row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataTable1Row Row {
                get {
                    return this.eventRow;
                }
            }
            
            [DebuggerNonUserCode()]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}

#pragma warning restore 1591