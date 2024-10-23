<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<header>
				<style>
					table{
						background-color: yellow;
					}
					.so{
						font-size: 24px;
						color: red;
					}
				</style>
			</header>
			<body>
				<h2>BANG LUONG THANG</h2>
				<xsl:apply-templates select="DS/congty"/>
				
			</body>
		</html>
    </xsl:template>

	<xsl:template match="congty">
		<xsl:apply-templates select="donvi"/>
	</xsl:template>

	<xsl:template match="donvi">
		<p> Ten cong ty: <xsl:value-of select="parent::congty/@tenct"/> </p>
		<p> Ten don vi: <xsl:value-of select="tendv"/> </p>
		<table>
			<tr>
				<th>STT</th>
				<th>Ho ten</th>
				<th>Ngay sinh</th>
				<th>Ngay cong</th>
				<th>Luong</th>
			</tr>
			<xsl:apply-templates select="nhanvien"/>
		</table>
		<hr/>
	</xsl:template>

	<xsl:template match="nhanvien">
		
		<tr>
			<td class="so"><xsl:value-of select="position()"/></td>
			<td><xsl:value-of select="hoten"/></td>
			<td class="so"><xsl:value-of select="ngaysinh"/></td>
			<td class="so"><xsl:value-of select="ngaycong"/></td>
			<xsl:choose>
				<xsl:when test="ngaycong &lt;= 20">
					<td class="so">
						<xsl:value-of select="ngaycong * 15000"/>
					</td>
				</xsl:when>
				<xsl:when test="ngaycong &lt;= 25">
					<td class="so">
						<xsl:value-of select="(ngaycong - 20) * 20000 + 20 * 15000"/>
					</td>
				</xsl:when>
				<xsl:otherwise>
					<td class="so">
						<xsl:value-of select="5 * 20000 + 20 * 15000 + (ngaycong - 25 ) * 25000"/>
					</td>
				</xsl:otherwise>
			</xsl:choose>
		</tr>
	</xsl:template>
</xsl:stylesheet>
