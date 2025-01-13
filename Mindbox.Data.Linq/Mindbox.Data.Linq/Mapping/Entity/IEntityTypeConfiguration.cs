﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Data.Linq.Mapping.Entity
{
	internal interface IEntityTypeConfiguration
	{
		Type EntityType { get; }
		TableAttribute TableAttribute { get; }


		IEnumerable<ColumnAttributeByMember> GetColumnAttributesByMember(DbModelBuilder dbModelBuilder);

		PrimitivePropertyConfiguration GetPrimaryKeyPropertyConfiguration();

		IEnumerable<AssociationAttributeByMember> GetAssociationAttributesByMember(DbModelBuilder dbModelBuilder);
	}
}
