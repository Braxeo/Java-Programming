import java.sql.*;

public class asd {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		try {
			String url = "jdbc:odbc:MySQL57";
			Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
			Connection c = DriverManager.getConnection(url);
			Statement st = c.createStatement();
			ResultSet rs = st.executeQuery("Select * from login");
			
			while(rs.next()){
				System.out.println(rs.getString(1));
			}
			
		}catch(Exception e){ System.out.println(e);}	
	
			
	}
}

