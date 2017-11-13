﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Marvin.Container;
using NUnit.Framework;

namespace Marvin.ClientFramework.Tests
{
    [TestFixture]
    public class AttributeTests
    {
        [Test]
        [TestCase(typeof(ClientModuleAttribute), LifeCycle.Singleton, typeof(IClientModule), AttributeTargets.Class)]
        [TestCase(typeof(ModuleShellAttribute), LifeCycle.Singleton, typeof(IClientModule), AttributeTargets.Class)]
        public void ClientModuleAttributeTest(Type attribute, LifeCycle lifeCycle, Type service, AttributeTargets target)
        {
            const string name = "HelloWorld";

            var att = (RegistrationAttribute)Activator.CreateInstance(attribute, name);

            Assert.AreEqual(att.Name, name, "Name was not equal");
            Assert.AreEqual(att.LifeStyle, lifeCycle, "Component will not be registerd as " + lifeCycle);

            var decorator = typeof(ClientModuleAttribute).GetCustomAttribute<AttributeUsageAttribute>();

            Assert.AreEqual(decorator.ValidOn, target, "Attribute is not valid on: " + target);
        }
    }
}