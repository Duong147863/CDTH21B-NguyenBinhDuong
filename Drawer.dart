import 'index_screen.dart';
import 'detail_screen.dart';
import 'package:flutter/material.dart';

class drawer extends StatelessWidget 
{
  const drawer({super.key, this.idx});
  final idx;
  @override
  Widget build(BuildContext context) 
  {
   return Drawer(    
         child: ListView(
          children: <Widget>[
            const DrawerHeader( 
              decoration: BoxDecoration(color: Colors.blue,
              ),
               child: Text('Menu',style: TextStyle(color: Colors.white, fontSize: 25,),
            ),
            ),
          ListTile(
              leading: Icon(Icons.home),
              title:Text('Trang chủ'),
             onTap: () {
                 Navigator.popUntil(context, (route) => route.isFirst );
                 Navigator.pushNamed(context, '/index');
             },
            ),
              
          ListTile(
              leading: Icon(Icons.account_circle_sharp),
              title:Text('Cá nhân'),
               onTap: () {
                 Navigator.popUntil(context, (route) => route.isFirst );
                 Navigator.pushNamed(context, '/profile');
             },
            )
        
          ],
        ),
        
    );
  }
  }