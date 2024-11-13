<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl ns"
    xmlns:ns="http://tempuri.org/Gptb1.xsd"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
        <html>
            <head>
                <title>Giải phương trình bậc 1</title>
            </head>
            <body>
                <!-- Sử dụng namespace để truy xuất đúng các phần tử vara và varb -->
                <xsl:variable name="varA" select="ns:DS/ns:vara"/>
                <xsl:variable name="varB" select="ns:DS/ns:varb"/>

                <p>
                    Giải phương trình bậc 1: 
                    <xsl:value-of select="$varA"/>x + 
                    <xsl:value-of select="$varB"/> = 0
                </p>

                <xsl:choose>
                    <!-- Trường hợp A = 0 và B != 0: phương trình vô nghiệm -->
                    <xsl:when test="$varA = 0 and $varB != 0">
                        <p>Phương trình vô nghiệm</p>
                    </xsl:when>

                    <!-- Trường hợp A = 0 và B = 0: phương trình vô số nghiệm -->
                    <xsl:when test="$varA = 0 and $varB = 0">
                        <p>Phương trình có vô số nghiệm</p>
                    </xsl:when>

                    <!-- Trường hợp còn lại: phương trình có nghiệm duy nhất -->
                    <xsl:otherwise>
                        <p>Nghiệm của phương trình là:</p>
                        <p>
                            X = 
                            <!-- Tính toán nghiệm và hiển thị kết quả -->
                            <xsl:value-of select="(-$varB) div ($varA)"/>
                        </p>
                    </xsl:otherwise>
                </xsl:choose>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>
