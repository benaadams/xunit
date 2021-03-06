﻿using Xunit.Abstractions;
using Xunit.Internal;
using Xunit.v3;

namespace Xunit.Runner.Common
{
	/// <summary>
	/// Class that maps test framework execution messages to events.
	/// </summary>
	public class ExecutionEventSink : _IMessageSink
	{
		/// <summary>
		/// Occurs when a <see cref="_AfterTestFinished"/> message is received.
		/// </summary>
		public event MessageHandler<_AfterTestFinished>? AfterTestFinishedEvent;

		/// <summary>
		/// Occurs when a <see cref="_AfterTestStarting"/> message is received.
		/// </summary>
		public event MessageHandler<_AfterTestStarting>? AfterTestStartingEvent;

		/// <summary>
		/// Occurs when a <see cref="_BeforeTestFinished"/> message is received.
		/// </summary>
		public event MessageHandler<_BeforeTestFinished>? BeforeTestFinishedEvent;

		/// <summary>
		/// Occurs when a <see cref="_BeforeTestStarting"/> message is received.
		/// </summary>
		public event MessageHandler<_BeforeTestStarting>? BeforeTestStartingEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestAssemblyCleanupFailure"/> message is received.
		/// </summary>
		public event MessageHandler<_TestAssemblyCleanupFailure>? TestAssemblyCleanupFailureEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestAssemblyFinished"/> message is received.
		/// </summary>
		public event MessageHandler<_TestAssemblyFinished>? TestAssemblyFinishedEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestAssemblyStarting"/> message is received.
		/// </summary>
		public event MessageHandler<_TestAssemblyStarting>? TestAssemblyStartingEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestCaseCleanupFailure"/> message is received.
		/// </summary>
		public event MessageHandler<_TestCaseCleanupFailure>? TestCaseCleanupFailureEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestCaseFinished"/> message is received.
		/// </summary>
		public event MessageHandler<_TestCaseFinished>? TestCaseFinishedEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestCaseStarting"/> message is received.
		/// </summary>
		public event MessageHandler<_TestCaseStarting>? TestCaseStartingEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestClassCleanupFailure"/> message is received.
		/// </summary>
		public event MessageHandler<_TestClassCleanupFailure>? TestClassCleanupFailureEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestClassConstructionFinished"/> message is received.
		/// </summary>
		public event MessageHandler<_TestClassConstructionFinished>? TestClassConstructionFinishedEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestClassConstructionStarting"/> message is received.
		/// </summary>
		public event MessageHandler<_TestClassConstructionStarting>? TestClassConstructionStartingEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestClassDisposeFinished"/> message is received.
		/// </summary>
		public event MessageHandler<_TestClassDisposeFinished>? TestClassDisposeFinishedEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestClassDisposeStarting"/> message is received.
		/// </summary>
		public event MessageHandler<_TestClassDisposeStarting>? TestClassDisposeStartingEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestClassFinished"/> message is received.
		/// </summary>
		public event MessageHandler<_TestClassFinished>? TestClassFinishedEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestClassStarting"/> message is received.
		/// </summary>
		public event MessageHandler<_TestClassStarting>? TestClassStartingEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestCleanupFailure"/> message is received.
		/// </summary>
		public event MessageHandler<_TestCleanupFailure>? TestCleanupFailureEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestCollectionCleanupFailure"/> message is received.
		/// </summary>
		public event MessageHandler<_TestCollectionCleanupFailure>? TestCollectionCleanupFailureEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestCollectionFinished"/> message is received.
		/// </summary>
		public event MessageHandler<_TestCollectionFinished>? TestCollectionFinishedEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestCollectionStarting"/> message is received.
		/// </summary>
		public event MessageHandler<_TestCollectionStarting>? TestCollectionStartingEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestFailed"/> message is received.
		/// </summary>
		public event MessageHandler<_TestFailed>? TestFailedEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestFinished"/> message is received.
		/// </summary>
		public event MessageHandler<_TestFinished>? TestFinishedEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestMethodCleanupFailure"/> message is received.
		/// </summary>
		public event MessageHandler<_TestMethodCleanupFailure>? TestMethodCleanupFailureEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestMethodFinished"/> message is received.
		/// </summary>
		public event MessageHandler<_TestMethodFinished>? TestMethodFinishedEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestMethodStarting"/> message is received.
		/// </summary>
		public event MessageHandler<_TestMethodStarting>? TestMethodStartingEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestOutput"/> message is received.
		/// </summary>
		public event MessageHandler<_TestOutput>? TestOutputEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestPassed"/> message is received.
		/// </summary>
		public event MessageHandler<_TestPassed>? TestPassedEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestSkipped"/> message is received.
		/// </summary>
		public event MessageHandler<_TestSkipped>? TestSkippedEvent;

		/// <summary>
		/// Occurs when a <see cref="_TestStarting"/> message is received.
		/// </summary>
		public event MessageHandler<_TestStarting>? TestStartingEvent;

		/// <inheritdoc/>
		public bool OnMessage(IMessageSinkMessage message)
		{
			Guard.ArgumentNotNull(nameof(message), message);

			return
				message.Dispatch(null, AfterTestFinishedEvent) &&
				message.Dispatch(null, AfterTestStartingEvent) &&
				message.Dispatch(null, BeforeTestFinishedEvent) &&
				message.Dispatch(null, BeforeTestStartingEvent) &&
				message.Dispatch(null, TestAssemblyCleanupFailureEvent) &&
				message.Dispatch(null, TestAssemblyFinishedEvent) &&
				message.Dispatch(null, TestAssemblyStartingEvent) &&
				message.Dispatch(null, TestCaseCleanupFailureEvent) &&
				message.Dispatch(null, TestCaseFinishedEvent) &&
				message.Dispatch(null, TestCaseStartingEvent) &&
				message.Dispatch(null, TestClassCleanupFailureEvent) &&
				message.Dispatch(null, TestClassConstructionFinishedEvent) &&
				message.Dispatch(null, TestClassConstructionStartingEvent) &&
				message.Dispatch(null, TestClassDisposeFinishedEvent) &&
				message.Dispatch(null, TestClassDisposeStartingEvent) &&
				message.Dispatch(null, TestClassFinishedEvent) &&
				message.Dispatch(null, TestClassStartingEvent) &&
				message.Dispatch(null, TestCleanupFailureEvent) &&
				message.Dispatch(null, TestCollectionCleanupFailureEvent) &&
				message.Dispatch(null, TestCollectionFinishedEvent) &&
				message.Dispatch(null, TestCollectionStartingEvent) &&
				message.Dispatch(null, TestFailedEvent) &&
				message.Dispatch(null, TestFinishedEvent) &&
				message.Dispatch(null, TestMethodCleanupFailureEvent) &&
				message.Dispatch(null, TestMethodFinishedEvent) &&
				message.Dispatch(null, TestMethodStartingEvent) &&
				message.Dispatch(null, TestOutputEvent) &&
				message.Dispatch(null, TestPassedEvent) &&
				message.Dispatch(null, TestSkippedEvent) &&
				message.Dispatch(null, TestStartingEvent);
		}
	}
}
