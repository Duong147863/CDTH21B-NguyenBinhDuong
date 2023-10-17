
import 'package:flutter/material.dart';
import 'detail_screen.dart';
import 'index_screen.dart';

class BottomNav extends StatelessWidget 
{
  const BottomNav({super.key, required this.idx});
  final idx;
  @override
  Widget build(BuildContext context) 
  {
    return BottomNavigationBar
    (
         fixedColor: Colors.blueAccent,
         items: const[
           BottomNavigationBarItem(
            label: "Trang chủ",
            icon: Icon(Icons.home),
           ),
            BottomNavigationBarItem(
            label: "Chi tiết",
            icon: Icon(Icons.star,),
           ),
         ],
        currentIndex: idx,
        onTap: (int indexOfItem) 
        { 
        if (indexOfItem==0){
          Navigator.popUntil(context, (route) => route.isFirst );
          Navigator.pushNamed(context, '/');
        }
        else
        {
          Navigator.popUntil(context, (route) => route.isFirst );
          Navigator.pushNamed(context, '/detail');
        }
        } 
    );
  }
}

    
