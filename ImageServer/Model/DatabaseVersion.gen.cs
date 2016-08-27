#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model
{
    using System;
    using System.Xml;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;
    using ClearCanvas.ImageServer.Enterprise.Command;
    using ClearCanvas.ImageServer.Model.EntityBrokers;

    [Serializable]
    public partial class DatabaseVersion: ServerEntity
    {
        #region Constructors
        public DatabaseVersion():base("DatabaseVersion_")
        {}
        public DatabaseVersion(
             String _major__
            ,String _minor__
            ,String _build__
            ,String _revision__
            ):base("DatabaseVersion_")
        {
            Major = _major__;
            Minor = _minor__;
            Build = _build__;
            Revision = _revision__;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="DatabaseVersion_", ColumnName="Major_")]
        public String Major
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="DatabaseVersion_", ColumnName="Minor_")]
        public String Minor
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="DatabaseVersion_", ColumnName="Build_")]
        public String Build
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="DatabaseVersion_", ColumnName="Revision_")]
        public String Revision
        { get; set; }
        #endregion

        #region Static Methods
        static public DatabaseVersion Load(ServerEntityKey key)
        {
            using (var context = new ServerExecutionContext())
            {
                return Load(context.ReadContext, key);
            }
        }
        static public DatabaseVersion Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<IDatabaseVersionEntityBroker>();
            DatabaseVersion theObject = broker.Load(key);
            return theObject;
        }
        static public DatabaseVersion Insert(DatabaseVersion entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                DatabaseVersion newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public DatabaseVersion Insert(IUpdateContext update, DatabaseVersion entity)
        {
            var broker = update.GetBroker<IDatabaseVersionEntityBroker>();
            var updateColumns = new DatabaseVersionUpdateColumns();
            updateColumns.Major = entity.Major;
            updateColumns.Minor = entity.Minor;
            updateColumns.Build = entity.Build;
            updateColumns.Revision = entity.Revision;
            DatabaseVersion newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}
