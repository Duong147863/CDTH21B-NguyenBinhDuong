import 'package:flutter/material.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:flutter/src/widgets/placeholder.dart';

class BottomNavigator extends StatelessWidget {
  const BottomNavigator({super.key, required this.index});
  final index;  

  @override
  Widget build(BuildContext context) {
    return BottomNavigationBar(
      fixedColor: Colors.green,
      items: const [
        BottomNavigationBarItem(
          icon: Icon(Icons.home),
          label: "Trang chủ"
        ),
        BottomNavigationBarItem(
          icon: Icon(Icons.notifications_none),
          label: "Thông báo"
        ),
        BottomNavigationBarItem(
          icon: Icon(Icons.account_circle),
          label: "Cá nhân"
        ),
      ],
      currentIndex: index,
      onTap: (int indexOfItem){
        if(indexOfItem == 0){
          Navigator.pop(context, (route) => route.isCurrent);
          Navigator.pushNamed(context, '/home');
        }
        if(indexOfItem == 1){
          Navigator.pop(context, (route) => route.isCurrent);
          Navigator.pushNamed(context, '/notify');
        }
        if(indexOfItem == 2){
          Navigator.pop(context, (route) => route.isCurrent);
          Navigator.pushNamed(context, '/profile');
        }
      },
    );
  }
}