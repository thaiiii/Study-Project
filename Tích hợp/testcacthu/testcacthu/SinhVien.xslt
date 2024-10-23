<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl ns"
				xmlns:ns="http://tempuri.org/SinhVien.xsd"

					>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<body>
				<table border="1">
					<tr>
						<th>STT</th>
						<th>MaSv</th>
						<th>TenSV</th>
						<th>GioiTinh</th>
						<th>NgaySinh</th>
						<th>MaLop</th>
					</tr>
					<xsl:for-each select="ns:Lop/ns:SinhVien">
						<tr>
							<td>
								<xsl:value-of select="position()"/>
							</td>

							<td>
								<xsl:value-of select="@MaSV"/>
							</td>
							<td>
								<xsl:value-of select="ns:TenSV"/>
							</td>
							<td>
								<xsl:value-of select="ns:GioiTinh"/>
							</td>
							<td>
								<xsl:value-of select="ns:NgaySinh"/>
							</td>
							<td>
								<xsl:value-of select="ns:MaLop"/>
							</td>
						</tr>
						
					</xsl:for-each>
					
				</table>
				
			</body>
			
		</html>    
	
	
	</xsl:template>
</xsl:stylesheet>
