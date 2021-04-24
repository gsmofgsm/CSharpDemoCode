using AutoFixture.Xunit2;
using System;
using AutoFixture;
using AutoFixture.AutoMoq;

namespace DemoCode.AutoMoq.Tests
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute()
            : base(() => new Fixture().Customize(new AutoMoqCustomization()))
        {
        }
    }
}
