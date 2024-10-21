<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

	<xsl:template match="lophoc">
		<html>
			<head>
				<title>Vi du lop hoc</title>
			</head>
			<body>
				<h2>Danh sach sinh vien</h2>
				<table border="1">
					<tr>
						<th>STT</th>
						<th>Ho ten</th>
						<th>Diem</th>
						<th>Dia chi</th>
						<th>Lan 1</th>
						<th>Lan 2</th>
						<th>Xep loai</th>
						
					</tr>
					<xsl:apply-templates select="sinhvien"/>
				</table>
				<br/>
				Số lượng sinh viên: <xsl:value-of select="count(sinhvien)"/>
				<br/>
				Tổng điểm sinh viên: <xsl:value-of select="sum(sinhvien/diem)"/>
			</body>
		</html>
	</xsl:template>

	<!-- Template sinhvien -->
	<xsl:template match="sinhvien">
		<tr>
			<td>
				<xsl:value-of select="position()"/>
			</td>
			<td>
				<xsl:value-of select="hoten"/>
			</td>
			<td>
				<xsl:value-of select="diem"/>
			</td>
			<td>
				<xsl:value-of select="diachi"/>
			</td>
			<td>
				<xsl:value-of select="diemHK/lan1"/>
			</td>
			<td>
				<xsl:value-of select="diemHK/lan2"/>
			</td>
			<td>
				<xsl:choose>
					<xsl:when test="diem > 80">Gioi</xsl:when>
					<xsl:when test="diem > 70">Kha</xsl:when>
					<xsl:otherwise>TB</xsl:otherwise>
				</xsl:choose>
			</td>
		</tr>
	</xsl:template>
</xsl:stylesheet>
