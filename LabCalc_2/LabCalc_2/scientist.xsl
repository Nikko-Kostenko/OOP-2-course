<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
version="1.0">

<xsl:output method='html'/>

<xsl:template match="scientistsDatabase">

<HTML>

<BODY>

<p>

<H2>Cписок наукових працівників</H2></p>

</BODY>

<BODY>

<TABLE border = "1">
<TR>
<th>факультет</th>
<th>кафедра</th>
<th>ім'я</th>
<th>степінь</th>
<th>стаж</th>
</TR>
<xsl:for-each select = "faculty">
  <tr>
<td>
<xsl:value-of select = "@FC_NAME"/>
</td>
  <xsl:for-each select = "cathedra">
    <tr>
      <th>
      <td>
      <xsl:value-of select = "@CT_NAME"/>
</td>
<xsl:for-each select = "scientist">
  <tr>
    <th>
      <th>
    <td>
<xsl:value-of select = "@SC_NAME"/>
</td>
<td>
<xsl:value-of select = "@SC_POST"/>
</td>
<td>
<xsl:value-of select = "@SC_WORKED_TIME"/>
</td>
      </th>
    </th>
  </tr>
</xsl:for-each>
      </th>
    </tr>
  </xsl:for-each>
  </tr>
</xsl:for-each>

</TABLE>
</BODY>
</HTML>
</xsl:template>
</xsl:stylesheet>