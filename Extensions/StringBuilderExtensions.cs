using System.Text;

namespace AWildErin.Utility.Extensions;

public static class StringBuilderExtensions
{
	private static string GetIndentString( int IndentLevel )
	{
		return new string( '\t', IndentLevel );
	}

	public static StringBuilder AppendIndentedLine(this StringBuilder StringBuilder, int Indent, string Text)
	{
		return StringBuilder.AppendLine($"{GetIndentString(Indent)}{Text}");
	}

	public static StringBuilder AppendIndented( this StringBuilder StringBuilder, int Indent, string Text )
	{
		return StringBuilder.Append( $"{GetIndentString( Indent )}{Text}" );
	}
}
