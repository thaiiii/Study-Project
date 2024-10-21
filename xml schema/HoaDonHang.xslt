<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<head>
				<title>
					Danh mục hóa đơn
				</title>
			</head>
			<body>
				<h2 style="text-align: center;">Phieu mua hang</h2>
				<table>
					<tr>
						<td>
							<b>Hoa don: </b>
							<xsl:value-of select="DS/HoaDon/MaHD"/>
						</td>
						<td>
							<b>Ngay ban: </b>
							<xsl:value-of select="DS/HoaDon/NgayBan"/>
						</td>
					</tr>
					<tr>
						<td>
							<b>Loại hàng: </b>
							<xsl:value-of select="DS/HoaDon/LoaiHang/@TenLoai"/>
						</td>
					</tr>
				</table>
				<table border="1">
					<tr>
						<th>Mã hàng</th>
						<th>Tên hàng</th>
						<th>Số lượng</th>
						<th>Đơn giá</th>
						<th>Thành tiền</th>
					</tr>
					<xsl:for-each select="DS/HoaDon/LoaiHang/Hang">
						<tr>
							<td>
								<xsl:value-of select="@MaHang"/>
							</td>
							<td>
								<xsl:value-of select="TenHang"/>
							</td>
							<td>
								<xsl:value-of select="SoLuong"/>
							</td>
							<td>
								<xsl:value-of select="DonGia"/>
							</td>
							<td>
								<xsl:value-of select="DonGia * SoLuong"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
				
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
