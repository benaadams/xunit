using Xunit.Abstractions;
using Xunit.Runner.Common;
using Xunit.v3;

// TODO: These will be replaced by their counterparts in xunit.v3.common/v3/Messages once we replace the message sink.
namespace Xunit.Runner.v2
{
	/// <summary>
	/// A message sent to implementations of <see cref="IRunnerReporter"/> when
	/// discovery is finished for a test assembly.
	/// </summary>
	public interface ITestAssemblyDiscoveryFinished : IMessageSinkMessage
	{
		/// <summary>
		/// Gets information about the assembly being discovered.
		/// </summary>
		XunitProjectAssembly Assembly { get; }

		/// <summary>
		/// Gets the options that were used during discovery.
		/// </summary>
		_ITestFrameworkDiscoveryOptions DiscoveryOptions { get; }

		/// <summary>
		/// Gets the number of test cases that were discovered. This is the raw
		/// number of test cases found before filtering is applied by the runner.
		/// </summary>
		int TestCasesDiscovered { get; }

		/// <summary>
		/// Gets the number of test cases that will be run. This is the number of
		/// test cases found after filtering is applied by the runner.
		/// </summary>
		int TestCasesToRun { get; }
	}
}
