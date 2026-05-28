using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace MSTestExtensions;

/* This code is auto-generated */
[DebuggerStepThrough]
[DebuggerNonUserCode]
public static class MsTestAssertions
{
	public static void AreEqual<T>(this IAssertion assertion, T expected, T actual)
	{
		Assert.AreEqual(expected, actual);
	}

	public static void AreEqual(this IAssertion assertion, string expected, string actual, bool ignoreCase)
	{
		Assert.AreEqual(expected, actual, ignoreCase);
	}

	public static void AreEqual(this IAssertion assertion, float expected, float actual, float delta)
	{
		Assert.AreEqual(expected, actual, delta);
	}

	public static void AreEqual(this IAssertion assertion, double expected, double actual, double delta,
		string message, [CallerArgumentExpression(nameof(expected))] string expectedExpression = "",
		[CallerArgumentExpression(nameof(actual))]
		string actualExpression = "")
	{
		Assert.AreEqual(expected, actual, delta, message, expectedExpression, actualExpression);
	}

	public static void AreEqual(this IAssertion assertion, object expected, object actual, string message,
		[CallerArgumentExpression(nameof(expected))]
		string expectedExpression = "",
		[CallerArgumentExpression(nameof(actual))]
		string actualExpression = "")
	{
		Assert.AreEqual(expected, actual, message, expectedExpression, actualExpression);
	}

	public static void AreEqual(this IAssertion assertion, float expected, float actual, float delta,
		string message, [CallerArgumentExpression(nameof(expected))] string expectedExpression = "",
		[CallerArgumentExpression(nameof(actual))]
		string actualExpression = "")
	{
		Assert.AreEqual(expected, actual, delta, message, expectedExpression, actualExpression);
	}

	public static void AreEqual<T>(this IAssertion assertion, T expected, T actual, string message,
		[CallerArgumentExpression(nameof(expected))]
		string expectedExpression = "",
		[CallerArgumentExpression(nameof(actual))]
		string actualExpression = "")
	{
		Assert.AreEqual(expected, actual, message, expectedExpression, actualExpression);
	}

	public static void AreEqual(this IAssertion assertion, double expected, double actual, double delta)
	{
		Assert.AreEqual(expected, actual, delta);
	}

	public static void AreEqual(this IAssertion assertion, object expected, object actual)
	{
		Assert.AreEqual(expected, actual);
	}

	public static void AreEqual(this IAssertion assertion, string expected, string actual, bool ignoreCase,
		CultureInfo culture)
	{
		Assert.AreEqual(expected, actual, ignoreCase, culture);
	}

	public static void AreEqual(this IAssertion assertion, string expected, string actual, bool ignoreCase,
		CultureInfo culture, string message, [CallerArgumentExpression(nameof(expected))] string expectedExpression = "",
		[CallerArgumentExpression(nameof(actual))]
		string actualExpression = "")
	{
		Assert.AreEqual(expected, actual, ignoreCase, culture, message, expectedExpression, actualExpression);
	}

	public static void AreEqual(this IAssertion assertion, string expected, string actual, bool ignoreCase,
		string message, [CallerArgumentExpression(nameof(expected))] string expectedExpression = "",
		[CallerArgumentExpression(nameof(actual))]
		string actualExpression = "")
	{
		Assert.AreEqual(expected, actual, ignoreCase, message, expectedExpression, actualExpression);
	}

	public static void AreNotEqual(this IAssertion assertion, string notExpected, string actual, bool ignoreCase,
		CultureInfo culture)
	{
		Assert.AreNotEqual(notExpected, actual, ignoreCase, culture);
	}

	public static void AreNotEqual(this IAssertion assertion, string notExpected, string actual, bool ignoreCase,
		CultureInfo culture, string message, [CallerArgumentExpression(nameof(notExpected))] string notExpectedExpression = "",
		[CallerArgumentExpression(nameof(actual))]
		string actualExpression = "")
	{
		Assert.AreNotEqual(notExpected, actual, ignoreCase, culture, message, notExpectedExpression, actualExpression);
	}

	public static void AreNotEqual(this IAssertion assertion, float notExpected, float actual, float delta)
	{
		Assert.AreNotEqual(notExpected, actual, delta);
	}

	public static void AreNotEqual(this IAssertion assertion, string notExpected, string actual, bool ignoreCase)
	{
		Assert.AreNotEqual(notExpected, actual, ignoreCase);
	}

	public static void AreNotEqual(this IAssertion assertion, double notExpected, double actual, double delta)
	{
		Assert.AreNotEqual(notExpected, actual, delta);
	}

	public static void AreNotEqual(this IAssertion assertion, double notExpected, double actual, double delta,
		string message, [CallerArgumentExpression(nameof(notExpected))] string notExpectedExpression = "",
		[CallerArgumentExpression(nameof(actual))]
		string actualExpression = "")
	{
		Assert.AreNotEqual(notExpected, actual, delta, message, notExpectedExpression, actualExpression);
	}

	public static void AreNotEqual(this IAssertion assertion, float notExpected, float actual, float delta,
		string message, [CallerArgumentExpression(nameof(notExpected))] string notExpectedExpression = "",
		[CallerArgumentExpression(nameof(actual))]
		string actualExpression = "")
	{
		Assert.AreNotEqual(notExpected, actual, delta, message, notExpectedExpression, actualExpression);
	}

	public static void AreNotEqual(this IAssertion assertion, string notExpected, string actual, bool ignoreCase,
		string message, [CallerArgumentExpression(nameof(notExpected))] string notExpectedExpression = "",
		[CallerArgumentExpression(nameof(actual))]
		string actualExpression = "")
	{
		Assert.AreNotEqual(notExpected, actual, ignoreCase, message, notExpectedExpression, actualExpression);
	}

	public static void AreNotEqual<T>(this IAssertion assertion, T notExpected, T actual)
	{
		Assert.AreNotEqual(notExpected, actual);
	}

	public static void AreNotEqual<T>(this IAssertion assertion, T notExpected, T actual, string message,
		[CallerArgumentExpression(nameof(notExpected))]
		string notExpectedExpression = "",
		[CallerArgumentExpression(nameof(actual))]
		string actualExpression = "")
	{
		Assert.AreNotEqual(notExpected, actual, message, notExpectedExpression, actualExpression);
	}

	public static void AreNotEqual(this IAssertion assertion, object notExpected, object actual, string message,
		[CallerArgumentExpression(nameof(notExpected))]
		string notExpectedExpression = "",
		[CallerArgumentExpression(nameof(actual))]
		string actualExpression = "")
	{
		Assert.AreNotEqual(notExpected, actual, message, notExpectedExpression, actualExpression);
	}

	public static void AreNotEqual(this IAssertion assertion, object notExpected, object actual)
	{
		Assert.AreNotEqual(notExpected, actual);
	}

	public static void AreNotSame(this IAssertion assertion, object notExpected, object actual)
	{
		Assert.AreNotSame(notExpected, actual);
	}

	public static void AreNotSame(this IAssertion assertion, object notExpected, object actual, string message,
		[CallerArgumentExpression(nameof(notExpected))]
		string notExpectedExpression = "",
		[CallerArgumentExpression(nameof(actual))]
		string actualExpression = "")
	{
		Assert.AreNotSame(notExpected, actual, message, notExpectedExpression, actualExpression);
	}

	public static void AreSame(this IAssertion assertion, object expected, object actual)
	{
		Assert.AreSame(expected, actual);
	}

	public static void AreSame(this IAssertion assertion, object expected, object actual, string message,
		[CallerArgumentExpression(nameof(expected))]
		string expectedExpression = "",
		[CallerArgumentExpression(nameof(actual))]
		string actualExpression = "")
	{
		Assert.AreSame(expected, actual, message, expectedExpression, actualExpression);
	}

	public static void Fail(this IAssertion assertion)
	{
		Assert.Fail();
	}

	public static void Fail(this IAssertion assertion, string message)
	{
		Assert.Fail(message);
	}

	public static void Inconclusive(this IAssertion assertion, string message)
	{
		Assert.Inconclusive(message);
	}

	public static void Inconclusive(this IAssertion assertion)
	{
		Assert.Inconclusive();
	}

	public static void IsFalse(this IAssertion assertion, bool condition)
	{
		Assert.IsFalse(condition);
	}

	public static void IsFalse(this IAssertion assertion, bool condition, string message,
		[CallerArgumentExpression(nameof(condition))]
		string conditionExpression = "")
	{
		Assert.IsFalse(condition, message, conditionExpression);
	}

	public static void IsInstanceOfType(this IAssertion assertion, object value, Type expectedType)
	{
		Assert.IsInstanceOfType(value, expectedType);
	}

	public static void IsInstanceOfType(this IAssertion assertion, object value, Type expectedType, string message,
		[CallerArgumentExpression(nameof(value))]
		string valueExpression = "")
	{
		Assert.IsInstanceOfType(value, expectedType, message, valueExpression);
	}

	public static void IsNotInstanceOfType(this IAssertion assertion, object value, Type wrongType, string message,
		[CallerArgumentExpression(nameof(value))]
		string valueExpression = "")
	{
		Assert.IsNotInstanceOfType(value, wrongType, message, valueExpression);
	}

	public static void IsNotInstanceOfType(this IAssertion assertion, object value, Type wrongType)
	{
		Assert.IsNotInstanceOfType(value, wrongType);
	}

	public static void IsNotNull(this IAssertion assertion, object value, string message,
		[CallerArgumentExpression(nameof(value))] string valueExpression = "")
	{
		Assert.IsNotNull(value, message, valueExpression);
	}

	public static void IsNotNull(this IAssertion assertion, object value)
	{
		Assert.IsNotNull(value);
	}

	public static void IsNull(this IAssertion assertion, object value, string message,
		[CallerArgumentExpression(nameof(value))] string valueExpression = "")
	{
		Assert.IsNull(value, message, valueExpression);
	}

	public static void IsNull(this IAssertion assertion, object value)
	{
		Assert.IsNull(value);
	}

	public static void IsTrue(this IAssertion assertion, bool condition, string message,
		[CallerArgumentExpression(nameof(condition))] string conditionExpression = "")
	{
		Assert.IsTrue(condition, message, conditionExpression);
	}

	public static void IsTrue(this IAssertion assertion, bool condition)
	{
		Assert.IsTrue(condition);
	}
}