import 'Drawer.dart';
import 'bottom_nav.dart';
import 'package:flutter/material.dart';
class index extends StatelessWidget {
  const index({super.key});

  @override
  Widget build(BuildContext context) {
   
    return Scaffold(
      appBar: AppBar(title: const Text("Index")),
      body:const Text ("Index "),
      drawer: const drawer(idx: 0,),
      bottomNavigationBar: const BottomNav(idx:0),
      
    );
  }
}