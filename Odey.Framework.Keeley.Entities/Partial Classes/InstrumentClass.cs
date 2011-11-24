using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Odey.Framework.Keeley.Entities.Enums;

namespace Odey.Framework.Keeley.Entities
{
    partial class InstrumentClass
    {

        private void MatchParentInstrumentClasses()
        {
            foreach (InstrumentClassRelationship relationship in this.ParentInstrumentClassRelationships)
            {
                if (relationship.InstrumentClassHierarchyId == (int)InstrumentClassHierarchyIds.FundManager)
                {
                    _fMParentInstrumentClassRelationship = relationship;
                }
                else if (relationship.InstrumentClassHierarchyId == (int)InstrumentClassHierarchyIds.Odey)
                {
                    _parentInstrumentClassRelationship = relationship;
                }
            }
            if (_fMParentInstrumentClassRelationship == null)
            {
                _fMParentInstrumentClassRelationship = CreateParentInstrumentClass(InstrumentClassHierarchyIds.FundManager);
            }
            if (_parentInstrumentClassRelationship == null)
            {
                _parentInstrumentClassRelationship = CreateParentInstrumentClass(InstrumentClassHierarchyIds.Odey);
            }
        }

        private InstrumentClassRelationship _fMParentInstrumentClassRelationship = null;
        private InstrumentClassRelationship FMParentInstrumentClassRelationship
        {
            get
            {
                if (_fMParentInstrumentClassRelationship == null)
                {
                    MatchParentInstrumentClasses();
                }
                return _fMParentInstrumentClassRelationship;
            }
        }

        public int? FMParentInstrumentClassId
        {
            get
            {
                if (FMParentInstrumentClassRelationship.ParentInstrumentClassID == default(int))
                {
                    return null;
                }
                else
                {
                    return FMParentInstrumentClassRelationship.ParentInstrumentClassID;
                }
            }
            set
            {
                FMParentInstrumentClassRelationship.ParentInstrumentClassID = value.Value;
            }
        }

        public int? ParentInstrumentClassId
        {
            get
            {
                if (ParentInstrumentClassRelationship.ParentInstrumentClassID == default(int))
                {
                    return null;
                }
                else
                {
                    return ParentInstrumentClassRelationship.ParentInstrumentClassID;
                }
            }
            set
            {
                ParentInstrumentClassRelationship.ParentInstrumentClassID = value.Value;
            }
        }

        private InstrumentClassRelationship CreateParentInstrumentClass( InstrumentClassHierarchyIds hierarchyId)
        {
            InstrumentClassRelationship relationship = new InstrumentClassRelationship();
            relationship.InstrumentClassHierarchyId = (int)hierarchyId;
            ParentInstrumentClassRelationships.Add(relationship);
            return relationship;
        }

        private InstrumentClassRelationship _parentInstrumentClassRelationship = null;
        private InstrumentClassRelationship ParentInstrumentClassRelationship
        {
            get
            {
                if (_parentInstrumentClassRelationship == null)
                {
                    MatchParentInstrumentClasses();
                }
                return _parentInstrumentClassRelationship;
            }
        }

    }
}
