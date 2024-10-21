<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl ns"
	xmlns:ns="http://tempuri.org/BenhNhan.xsd" 
>
    <xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<body>
				<table border="1">
					<tr>
						<td>BENH VIEN DA KHOA</td>
						<td>
							<b>DANH SACH BENH NHAN</b>
						</td>
					</tr>
				</table>

				<!-- Bắt đầu vòng lặp qua các khoa -->
				<xsl:for-each select="ns:BenhVien/ns:Khoa">
					<h2>
						Khoa: <xsl:value-of select="ns:TenKhoa"/>
					</h2>
					<table border="1">
						<tr>
							<th>STT</th>
							<th>Họ tên</th>
							<th>Ngày nhập viện</th>
							<th>Số ngày</th>
							<th>Số tiền</th>
						</tr>

						<!-- Bắt đầu vòng lặp qua các bệnh nhân trong mỗi phòng điều trị -->
						<xsl:for-each select="ns:PhongDieuTri/ns:BenhNhan">
							<tr>
								<td>
									<xsl:value-of select="position()"/>
								</td>
								<td>
									<xsl:value-of select="ns:HoTen"/>
								</td>
								<td>
									<xsl:value-of select="ns:NgayNhapVien"/>
								</td>
								<td>
									<xsl:value-of select="ns:SoNgay"/>
								</td>
								<td>
									<xsl:value-of select="ns:SoNgay * 15000"/>
								</td>
							</tr>
						</xsl:for-each>
					</table>
				</xsl:for-each>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
