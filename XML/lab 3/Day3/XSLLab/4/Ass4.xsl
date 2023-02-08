<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:fo="http://www.w3.org/1999/XSL/Format">
<xsl:template match="CATALOG">
<xsl:element name="h1">
<xsl:text> My CD Collection </xsl:text>
</xsl:element>

<table border="1">
	<tbody>
		<tr bgcolor="green">
			<th>Title</th>
			<th>Artist</th>
		</tr>
		<xsl:for-each select="CD[PRICE>10]">
		<tr>
			<td><xsl:value-of select="TITLE"></xsl:value-of></td>
			<td><xsl:value-of select="ARTIST"></xsl:value-of></td>
		</tr>
		
		</xsl:for-each>
	</tbody>
</table>


</xsl:template>
</xsl:stylesheet>