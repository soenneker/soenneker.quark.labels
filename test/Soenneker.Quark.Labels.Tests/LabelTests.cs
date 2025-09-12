using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Labels.Tests;

[Collection("Collection")]
public sealed class LabelTests : FixturedUnitTest
{
    public LabelTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
        // Label is now a Razor component, so integration tests would be more appropriate
        // This test serves as a placeholder for future component testing
    }
}
