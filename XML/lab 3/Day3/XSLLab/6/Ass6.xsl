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
		<xsl:for-each select="CD">
		<xsl:choose>
			<xsl:when test="PRICE>10">
			<tr>
				<td><xsl:value-of select="TITLE"></xsl:value-of></td>
				<td bgcolor="red" ><xsl:value-of select="PRICE"></xsl:value-of></td>
			</tr>
			</xsl:when>
		<xsl:otherwise>
		<tr>
				<td><xsl:value-of select="TITLE"></xsl:value-of></td>
				<td bgcolor="green" ><xsl:value-of select="PRICE"></xsl:value-of></td>
			</tr>
		</xsl:otherwise>
		</xsl:choose>
	
		</xsl:for-each>
	</tbody>
</table>
		
		
		
</xsl:template>
</xsl:stylesheet>