#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

class Card
{
	friend ostream &operator <<(ostream&, const Card&);
	public:
	Card(int p, int n):pattern(p),number(n){}
	
	int operator >= (Card& aicard)
	{
		if(this->number > aicard.number)
		{
			//Player�ӧQ
			return 1;
		}
		else if (this->number == aicard.number)
		{
			if(this->pattern >= aicard.pattern)
				return 1;
			else
				return 0;
		}
		else
			return 0;
	}
	
	private:
		int pattern;
		int number;
};

ostream &operator <<(ostream& out, const Card& card)
{
	switch(card.pattern)
	{
		case 0:
			out<<"club ";
		break;
		
		case 1:
			out<<"diamond ";
		break;
		
		case 2:
			out<<"heart ";
		break;
		
		case 3:
			out<<"spades ";
		break;
		
		default:
			out<<"GG\n";
		break;
	}
	
	switch(card.number)
	{
		case 8:
			out<<'J';
		break;
		
		case 9:
			out<<'Q';
		break;
		
		case 10:
			out<<'K';
		break;
		
		case 11:
			out<<1;
		break;
		
		case 12:
			out<<2;
		break;
		
		default:
			out<<(card.number+3);
	}
	return out;
}

/*
template <typename T>
void Comparison(T v1, T v2)
{
	cout<<"player: "<<v1<<" VS ai: "<<v2<<endl;
	
	if(v1 >= v2)
		cout<<"Player�ӧQ~�X�h�p�߳Q�k�ۯ{���~\n"<<endl;
	else
		cout<<"Player����~�A�s�v�ܩi�����L�������L!?\n"<<endl;
		
	return;
}
*/


void Comparison(int int_player, int int_ai)
{
	cout<<"player: "<<int_player<<" VS ai: "<<int_ai<<endl;
	
	if(int_player >= int_ai)
		cout<<"Player�ӧQ~�X�h�p�߳Q�k�ۯ{���~\n"<<endl;
	else
		cout<<"Player����~�A�s�v�ܩi�����L�������L!?\n"<<endl;
		
	return;
}

void Comparison(float float_player, float float_ai)
{
	cout<<"player: "<<float_player<<" VS ai: "<<float_ai<<endl;
	
	if(float_player >= float_ai)
		cout<<"Player�ӧQ~�X�h�p�߳Q�k�ۯ{���~\n"<<endl;
	else
		cout<<"Player����~�A�s�v�ܩi�����L�������L!?\n"<<endl;
		
	return;
}

void Comparison(Card& player, Card& ai)
{
	cout<<"player: "<<player<<" VS ai: "<<ai<<endl;
	
	if(player >= ai)
		cout<<"Player�ӧQ~�X�h�p�߳Q�k�ۯ{���~\n"<<endl;
	else
		cout<<"Player����~�A�s�v�ܩi�����L�������L!?\n"<<endl;
		
	return;
}

/*
void Comparison(int int_player, int int_ai, int a)
{
	cout<<"player: "<<int_player<<" VS ai: "<<int_ai<<endl;
	
	if(int_player >= int_ai)
		cout<<"Player�ӧQ~�X�h�p�߳Q�k�ۯ{���11~\n"<<endl;
	else
		cout<<"Player����~�A�s�v�ܩi�����L�������L!?11\n"<<endl;
		
	return;
}
*/

/*
int Comparison(int int_player, int int_ai)
{
	cout<<"player: "<<int_player<<" VS ai: "<<int_ai<<endl;
	cout<<"12654135"<<endl;
	return int_player >= int_ai ? 1 : 0;
}
*/

int main()
{
	//��j�p	
	//random seed
	srand(time(NULL));
	
	char mode;
	int con = 1;
	/*
	int int_player, int_ai, con = 1;
	float float_player, float_ai;

	
	while(con)
	{
		cout<<"��j�p�C��\n�п�J����Ҧ� \"i\" => integer mode  \"f\" => float \"e\" => ending"<<endl;
	
		cin>>mode;
	
		switch(mode)
		{
			case 'i':
				cout<<"���ɶ}�l!!"<<endl;
				int_player = rand();
				int_ai = rand();
				Comparison(int_player, int_ai);
			break;
		
			case 'f':
				cout<<"���ɶ}�l!!"<<endl;
				float_player = rand()/(float)(RAND_MAX + 1);
				float_ai = rand()/(float)(RAND_MAX + 1);
				Comparison(float_player, float_ai);
			break;
			
			case 'e':
				cout<<"�A�|�F�A�S�i�𪺤p����\n"<<endl;
				con = 0;
			break;
		
			default:
				cout<<"�ݤ�������r?\n"<<endl;
		}
	}
	*/
	
	while(con)
	{
		cout<<"��j�p�C��\n�п�J�Ҧ� \"s\" => start the game  \"e\" => ending"<<endl;
		
		cin>>mode;
		
		Card mycard(rand()%4, rand()%13);
		Card aicard(rand()%4, rand()%13);
		
		//mycard = aicard;
		//Card* c = &mycard;
		//cout<<(mycard, aicard)<<endl;
		
	
		switch(mode)
		{
			case 's':
				cout<<"���ɶ}�l!!"<<endl;
				Comparison(mycard, aicard);
			break;
			
			case 'e':
				cout<<"�A�|�F�A�S�i�𪺤p����\n"<<endl;
				con = 0;
			break;
		
			default:
				cout<<"�ݤ�������r?\n"<<endl;
		}
	}
	
	return 0;
}
