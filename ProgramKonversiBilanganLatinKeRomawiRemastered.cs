/*
* Title               : Latin Numeral to Roman Numeral Converter (ProgramKonversiBilanganLatinKeRomawi.cs)
* Program Description : To Convert Any Latin Numeral to Roman Numeral
* Author              : Muhammad Hasbi, S.T.
* Interface           : Console
* IDE                 : Notepad ++ v6.9.2 & Mono Project v4.2.3
* Operating System    : Windows 8 Pro 
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramKonversiBilanganLatinKeRomawi{
	struct Pecahan{
		public int i,v,x,l,c,d,m;
	}
	class ProgramKonversiBilanganLatinKeRomawi{
		public static void Main(string[] args){
			int input=0;
			System.Console.Out.WriteLine("Masukkan Angka Latin yang Ingin DiKonversi Ke Angka Romawi: ");
			input=System.Convert.ToInt32(System.Console.In.ReadLine());
			ProgramKonversiBilanganLatinKeRomawi Ro =new ProgramKonversiBilanganLatinKeRomawi();
			string RomanNumeral=Ro.Romawi();
			System.Console.Out.WriteLine(RomanNumeral);
		}
		public Romawi(string Roma){
			try {
			string Roman="";
			int sisa=0;
			Pecahan p;
			p.i=0;
			p.v=0;
			p.x=0;
			p.l=0;
			p.c=0;
			p.d=0;
			p.m=0;
			string m="",d="",c="",l="",x="",v="",I="";
			string seribu="M", seratus="C", sepuluh="X",satu="I";
			p.m=input/1000;
			sisa=input%1000;
			p.d=sisa/500;
			sisa=sisa%500;
			p.c=sisa/100;
			sisa=sisa%100;
			p.l=sisa/50;
			sisa=sisa%50;
			p.x=sisa/10;
			sisa=sisa%10;
			p.v=sisa/5;
			p.i=sisa%5;
			if (p.m>0){
				if(p.m==1){
					m="M";
				} else if (p.m>1){
					int i_m=1;
					m="M";
					while (i_m<p.m){
						m=m+seribu;
						i_m=i_m+1;
					}
				} else {
					m="";
				}
			} else {
				m="";
			}
			System.Console.Out.WriteLine("{0}:{1}",p.m,m);
			if (p.d>0){
				if(p.d==1){
					if ((p.c>0)&&(p.c<4)){
						d="D";
						int i_d=0;
						for(i_d=0;i_d<p.c;i_d=i_d+1){
							d=d+seratus;
						}
					} else if(p.c==4){
						string m2="M";
						string c2="C";
						d=c2+m2;
					} else if ((p.d==1)&&(p.c==0)){
						d="D";
					} else {
						d="";
					}
				} else {
					d="";
				}
			} else {
				d="";
			}
			System.Console.Out.WriteLine("{0}:{1}",p.d,d);
			if (p.c>0){
				if((p.c>0)&&(p.d==0)){
					if (p.c==1){
						c="C";
					} else if ((p.c>1)&&(p.c<4)){
						c="C";
						int i_c=1;
						for (i_c=1;i_c<p.c;i_c=i_c+1){
							c=c+seratus;
						}
					} else if (p.c==4){
						string d2="D";
						string c3="C";
						c=c3+d2;
					} else {
						c="";
					}
				}
			} else {
				c="";
			}
			System.Console.Out.WriteLine("{0}:{1}",p.c,c);
			if (p.l>0){
				if (p.l==1){
					if((p.x>0)&&(p.x<4)){
						l="L";
						int i_l=0;
						for (i_l=0;i_l<p.x;i_l=i_l+1){
							l=l+sepuluh;
						}
					} else if(p.x==4){
						string c4="C";
						string x2="X";
						l=x2+c4;
					} else if((p.l==1)&&(p.x==0)) {
						l="L";
					} else {
						l="";
					}
				} else {
					l="";
				}
			} else {
				l="";
			}
			System.Console.Out.WriteLine("{0}:{1}",p.l,l);
				if (p.x>0){
					if ((p.x>0)&&(p.l==0)){
						if (p.x==1){
							x="X";
						} else if ((p.x>1)&&(p.x<4)){
							x="X";
							int i_x=1;
							for (i_x=1;i_x<p.x;i_x=i_x+1){
								x=x+sepuluh;
							}
						} else if (p.x==4){
							string l2="L";
							string x3="X";
							x=x3+l2;
						} else if(p.x==0){
							x="";
						} else {
							x="";
						}
					}
				} else {
					x="";
				}
				System.Console.Out.WriteLine("{0}:{1}",p.x,x);
				if((p.i>0)||(p.v>0)){
					if ((p.v==1)&&(p.i==0)){
						v="V";
					} else if((p.i==4)&&(p.v==0)){
						I="IV";
					} else if (((p.i<4)&&(p.i>1))&&(p.v==0)){
						I="I";
						int i_I=1;
						for (i_I=1;i_I<p.i;i_I=i_I+1){
							I= I + satu;
						} 	
					} else if((p.i==1)&&(p.v==0)){
						I="I";
					} else if ((p.v==1)&&((p.i>0)&&(p.i<4))){
						I="I";
						v="V";
						int i_I=1;
						for(i_I=1;i_I<p.i;i_I=i_I+1){
							v=v+I;
						}
					} else if ((p.i==4)&&(p.v==1)){
						string x4="X";
						I="I";
						I=I+x4;
					} else {
						I="";
						v="";
					}
				} else {
					I="";
					v="";
				}
				System.Console.Out.WriteLine("{0}:{1}",p.v,v);
				System.Console.Out.WriteLine("{0}:{1}",p.i,I);
			Roman=m+d+c+l+x+v+I;
			return Roman;
			}
			catch (InvalidCastException e){
				throw new Exception("Wrong Input!!",e);
			}
		}
	}
}
