<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl ns"
				xmlns:ns="http://tempuri.org/Bai1.xsd"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">

		<html>
			<style>
				.title{
					font-weight: bold;
					color: green;
					font-size:25px;
					background-color: red;
					text-align: center;
				}
				.so{
					text-align:right;
				}
				.chuoi{
					text-align:left;
				}
				table {
					
					width: 100%;
					border-collapse: collapse;
					border: 2px solid #000;
				}
				td,th {
					border:1px solid #000;
				}
			</style>
			
			<body>
				<h2 style="text-align:center">BANG LUONG THANG 11-2020</h2>
				<xsl:apply-templates select="ns:congty/ns:donvi"/>
				
			
			
			
			</body>
		</html>
		
    </xsl:template>

	<xsl:template match="ns:donvi">
		<p>Ma don vi: <xsl:value-of select="@madv"/></p>
		<p>Ten don vi: <xsl:value-of select="ns:tendv"/></p>
		<p>Dien thoai: <xsl:value-of select="ns:dienthoai"/></p>
		<p class="title">DANH SACH NHAN VIEN</p>
		<table>
			<tr>
				<th>So tt</th>
				<th>Ma nv</th>
				<th>Ho ten</th>
				<th>Ngay sinh</th>
				<th>HS luong</th>
				<th>Luong</th>
			</tr>
			<xsl:apply-templates select="ns:nhanvien"/>
		</table>
		<h2 style="text-align:right">THU TRUONG DON VI</h2>
		<hr/>
	</xsl:template>


	<xsl:template match="ns:nhanvien">

		<xsl:if test ="ns:hsl>=3">
			<tr>
				<td class="so">
					<xsl:value-of select="position()"/>
				</td>
				<td class="chuoi">
					<xsl:value-of select="@manv"/>
				</td>
				<td class="chuoi">
					<xsl:value-of select="ns:hoten"/>
				</td>
				<td class="so">
					<xsl:value-of select="ns:ngaysinh"/>
				</td>
				<td class="so">
					<xsl:value-of select="ns:hsl"/>
				</td>
				<td class="so">
					<xsl:value-of select="ns:hsl*730000"/>
				</td>

			</tr>	
		</xsl:if>
		
		
	</xsl:template>
	
</xsl:stylesheet>
