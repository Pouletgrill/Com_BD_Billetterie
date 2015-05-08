/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package test;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.*;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import oracle.jdbc.OracleTypes;
import oracle.jdbc.pool.OracleDataSource;

/**
 *
 * @author Francois
 */
@WebServlet(name = "TableTest", urlPatterns =
{
    "/TableTest"
})
public class TableTest extends HttpServlet
{

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException
    {
        response.setContentType("text/html;charset=UTF-8");
        try (PrintWriter out = response.getWriter())
        {
            /* TODO output your page here. You may use following sample code. */
            out.println("<!DOCTYPE html>");
            out.println("<html>");
            out.println("<head>");
            out.println("<title>Servlet TableTest</title>");
            out.println(ProduireCss());
            out.println("</head>");
            out.println("<body>");
            
            if (request.getParameter("billets") != null)
            {
                out.println("BILLETS");
                out.println("<hr />");
                out.println(EcrireTableau("{ ?= call PKG_BILLETS.LISTER_BILLETS }"));
                out.println("<br />");
            }
            if (request.getParameter("fideles") != null)
            {
                out.println("FIDELES");
                out.println("<hr />");
                out.println(EcrireTableau("{ ?= call PKG_BILLETS.LISTER_FIDELES }"));
                out.println("<br />");
            }
            
            out.println("</body>");
            out.println("</html>");
        } catch (Exception e)
        {
            e.printStackTrace();
        }
    }

    private String EcrireTableau(String call) throws Exception
    {
        String tableau = "<table><tr>";
        
        // Se connecte à la création de l'objet
        // throws SQLException
        ConnexionOracle bd = new ConnexionOracle();
        
        CallableStatement callstm = bd.prepareCall(call);
        callstm.registerOutParameter(1, OracleTypes.CURSOR);
        callstm.execute();
        ResultSet rst = (ResultSet)callstm.getObject(1);
        ResultSetMetaData meta = rst.getMetaData();

        for (int i = 1; i <= meta.getColumnCount(); i++)
        {
            tableau += "<td>" + meta.getColumnName(i) + "</td>";
        }
        tableau += "</tr>";

        while (rst.next())
        {
            tableau += "<tr>";
            for (int i = 1; i <= meta.getColumnCount(); i++)
            {
                tableau += "<td>" + EcrireDonnee(rst.getObject(i), meta.getColumnType(i)) + "</td>";
            }
            tableau += "</tr>";
        }

        tableau += "</table>";
        
        rst.close();
        bd.deconnecter();
        
        return tableau;
    }

    private String EcrireDonnee(Object in, int type) throws Exception
    {
        String out = in.toString();

        if (type == OracleTypes.TIMESTAMP)
        {
            out = out.substring(0, out.indexOf(" "));
        }

        return out;
    }

    private String ProduireCss()
    {
        String css = "<style type=\"text/css\">";

        css += "table, tr, td {border: 1px solid black; border-collapse: collapse; text-align: center;}";
        css += "tr:first-child {background-color: lightgray;}";

        css += "</style>";
        return css;
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException
    {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException
    {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo()
    {
        return "Short description";
    }// </editor-fold>
}
