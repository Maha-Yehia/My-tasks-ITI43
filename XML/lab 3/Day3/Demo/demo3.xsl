<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:fo="http://www.w3.org/1999/XSL/Format">
<xsl:template match="food_list">
<table border="1">
	<tbody>
		<tr>
			<th>Index</th>
			<th>name</th>
			<th>carbs</th>
			<th>fiber</th>
			<th>fat</th>
			<th>kj</th>
		</tr>
<!--		<xsl:for-each select="food_item[carbs_per_serving > 50]">
[@type = 'fruit' or @type = 'seafood']
-->
<xsl:for-each select="food_item">
<xsl:sort select="carbs_per_serving" data-type="number"  order="descending"></xsl:sort>
		<!--<xsl:choose>
			<xsl:when test="@type = 'fruit'">-->
			<!--<xsl:if test="@type= 'fruit'">-->
			<tr style="background-color:red">
			<td><xsl:value-of select="position()"/></td>
			<td><xsl:value-of select="name"/></td>
			<td><xsl:value-of select="carbs_per_serving"/></td>
			<td><xsl:value-of select="fiber_per_serving"/></td>
			<td><xsl:value-of select="fat_per_serving"/></td>
			<td><xsl:value-of select="kj_per_serving"/></td>
		</tr>
<!--
			</xsl:if>
			<xsl:if test="@type ='seafood'">
			<tr style="background-color:red">
			<td><xsl:value-of select="position()"/></td>
			<td><xsl:value-of select="name"/></td>
			<td><xsl:value-of select="carbs_per_serving"/></td>
			<td><xsl:value-of select="fiber_per_serving"/></td>
			<td><xsl:value-of select="fat_per_serving"/></td>
			<td><xsl:value-of select="kj_per_serving"/></td>
		</tr>

			</xsl:if>-->
					<!--</xsl:when>
			<xsl:otherwise>
						<tr>
			<td><xsl:value-of select="name"/></td>
			<td><xsl:value-of select="carbs_per_serving"/></td>
			<td><xsl:value-of select="fiber_per_serving"/></td>
			<td><xsl:value-of select="fat_per_serving"/></td>
			<td><xsl:value-of select="kj_per_serving"/></td>
		</tr>

			</xsl:otherwise>
		</xsl:choose>-->
	</xsl:for-each>
	</tbody>
</table>
	
</xsl:template>
</xsl:stylesheet>
