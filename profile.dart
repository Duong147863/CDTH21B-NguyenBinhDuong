import 'Drawer.dart';
import 'bottom_nav.dart';
import 'package:flutter/material.dart';
class profile extends StatelessWidget {
  const profile({super.key});

  @override
  Widget build(BuildContext context) {
   
    return Scaffold(
      appBar: AppBar(title: const Text("profile")),
      body:const Text ("profile"),
      drawer: const drawer(idx: 1,),
       bottomNavigationBar: const BottomNav(idx:0),
      
    );
  }
}