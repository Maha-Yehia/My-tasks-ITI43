<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:fo="http://www.w3.org/1999/XSL/Format">
<xsl:template match="food_list">
<table border="1" bgcolor="yellow">
	<tbody>
		<tr>
			<th>name</th>
			<th>carbs</th>
			<th>fiber</th>
			<th>fat</th>
			<th>kj</th>
		</tr>
		<xsl:for-each select="food_item"><!--[@type = 'fruit']-->
		<xsl:variable name="rows">
			<td><xsl:value-of select="name"/></td>
			<td><xsl:value-of select="carbs_per_serving"/></td>
			<td><xsl:value-of select="fiber_per_serving"/></td>
			<td><xsl:value-of select="fat_per_serving"/></td>
			<td><xsl:value-of select="kj_per_serving"/></td>
		</xsl:variable>
		<xsl:if test="@type='grain'">
		<tr style="background-color: red">
			<xsl:copy-of select="$rows"/>	
		</tr>
		</xsl:if>
		<xsl:if test="@type='fruit'">
		<tr style="background-color: green">
			<xsl:copy-of select="$rows"/>	
		</tr>
		</xsl:if>
		<!--<xsl:variable name="Color" select="">
			<xsl:if test="@type = 'grain'">
				'red'
			</xsl:if>
			<xsl:if test="@type = 'fruit'">
				'green'
			</xsl:if>
			<xsl:if test="@type = 'vegetable'">
				'pink'
			</xsl:if>-->
			<!--<xsl:if test="@type = 'seafood'">
				'blue'
			</xsl:if>-->
		<!--</xsl:variable>-->
		<!--<xsl:if test="@type = 'grain'">-->
<!--		<tr style="background-color:{$Color}">
			<td><xsl:value-of select="name"/></td>
			<td><xsl:value-of select="carbs_per_serving"/></td>
			<td><xsl:value-of select="fiber_per_serving"/></td>
			<td><xsl:value-of select="fat_per_serving"/></td>
			<td><xsl:value-of select="kj_per_serving"/></td>
		</tr>-->
<!--
		</xsl:if>
		<xsl:if test="@type = 'fruit'">
		<tr style="background-color:green">
			<td><xsl:value-of select="name"/></td>
			<td><xsl:value-of select="carbs_per_serving"/></td>
			<td><xsl:value-of select="fiber_per_serving"/></td>
			<td><xsl:value-of select="fat_per_serving"/></td>
			<td><xsl:value-of select="kj_per_serving"/></td>
		</tr>
		</xsl:if>-->
		</xsl:for-each>
	</tbody>
</table>

</xsl:template>
</xsl:stylesheet>
