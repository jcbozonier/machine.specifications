﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications.Model;
using NUnit.Framework;

namespace Machine.Specifications.Factories
{
  [TestFixture]
  public class SpecificationFactoryTests : With<SpecificationWithSingleRequirement>
  {
    [Test]
    public void ShouldSetType()
    {
      description.Type.Name.ShouldEqual("SpecificationWithSingleRequirement");
    }
  }
}